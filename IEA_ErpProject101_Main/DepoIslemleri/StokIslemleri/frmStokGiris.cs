﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject101_Main.BilgiGirisIslemleri;
using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;

namespace IEA_ErpProject101_Main.DepoIslemleri.StokIslemleri
{
    public partial class frmStokGiris : Ortaklar
    {
        //private ErpProjectWMPEntities db = new ErpProjectWMPEntities();
        //private formlar f = new formlar();
        //private Numaralar n = new Numaralar();

        public string[] MyArray { get; set; }

        public frmStokGiris()
        {
            InitializeComponent();
        }

        private void frmStokGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }

        private void ComboDoldur()
        {
            txtGirisTipi.DataSource = Enum.GetValues(typeof(GirisTipleri));
            txtGenelNo.Text = n.StokGirisGenelKodu();
            try
            {
                txtUrnCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection veri = new AutoCompleteStringCollection();

                var drinst = db.tblUrunler.Where(x=>x.isActive==true).Select(item => item.UrunKodu).Distinct();

                foreach (string urun in drinst)
                {
                    veri.Add(urun);
                    txtUrnCombo.Items.Add(urun);
                }
                txtUrnCombo.AutoCompleteCustomSource = veri;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            int dgv;
            dgv = txtUrnCombo.Items.Count;
            MyArray = new string[dgv];
            for (int p = 0; p < dgv; p++)
            {
                MyArray[p] = txtUrnCombo.Items[p].ToString();
            }

            txtCariGrup.DataSource = db.tblCariGruplari.ToList();
            txtCariGrup.ValueMember = "Id";
            txtCariGrup.DisplayMember = "GrupAdi";
            txtCariGrup.SelectedIndex = -1;
        }

        private void YeniKayit()
        {
            if (txtCariGrup.Text=="")
            {
                MessageBox.Show("Giris turunu secmediniz. Lutfen secim yapin.");
                return;
            }

            Liste.AllowUserToAddRows = false;
            try
            {
                #region Stok Giris Ust Tablosuna kayit
                tblStokGirisUst ust = new tblStokGirisUst
                {
                    GenelNo = int.Parse(txtGenelNo.Text),
                    CariGrupId = (int)txtCariGrup.SelectedValue,
                    CariAdiId = db.tblCariler.First(x => x.CariAdi == txtCariAdi.Text).Id,
                    GirisTipi = (int)txtGirisTipi.SelectedValue,
                    FaturaNo = txtFaturaNo.Text,
                    FaturaTarih = txtGirisTarih.Value,
                    Aciklama = txtAciklama.Text,
                    isActive = true,
                    SaveDate = DateTime.Now,
                    SaveUserId = 1
                };
                db.tblStokGirisUst.Add(ust);
                db.SaveChanges(); 
                #endregion

                tblStokDurum[] drm = new tblStokDurum[Liste.RowCount];
                tblStokGirisAlt[] alt = new tblStokGirisAlt[Liste.RowCount];

                for (int i = 0; i < Liste.RowCount; i++)
                {
                    string barkod = Liste.Rows[i].Cells[2].Value.ToString() + "/" +
                                    Liste.Rows[i].Cells[3].Value.ToString();


                    #region Stok Durum Tablosuna kayit
                    drm[i] = new tblStokDurum();
                    var srg = (from s in db.tblStokDurum
                               where s.Barkod == barkod
                               select new { stokadet = s.StokAdet, rafadet = s.RafAdet }).ToList();

                    if (srg.Count == 0)
                    {
                        drm[i].StokKodu = "1";
                        drm[i].Barkod = barkod;
                        drm[i].Urun = Liste.Rows[i].Cells[2].Value.ToString();
                        drm[i].Lot = Liste.Rows[i].Cells[3].Value.ToString();
                        drm[i].StokAdet = int.Parse(Liste.Rows[i].Cells[4].Value.ToString());
                        drm[i].RafAdet = int.Parse(Liste.Rows[i].Cells[4].Value.ToString());
                        drm[i].KonsinyeAdet = 0;
                        drm[i].SubeAdet = 0;
                        drm[i].UT = DateTime.Parse(Liste.Rows[i].Cells[6].Value.ToString());
                        drm[i].SKT = DateTime.Parse(Liste.Rows[i].Cells[7].Value.ToString());
                        db.tblStokDurum.Add(drm[i]);
                        db.SaveChanges();
                    }
                    else
                    {
                        tblStokDurum sdurum = db.tblStokDurum.First(x => x.Barkod == barkod);
                        sdurum.StokAdet += Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                        sdurum.RafAdet += Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                        db.SaveChanges();
                    }

                    #endregion


                    #region Stok Giris Alt tablosuna kayit
                    alt[i] = new tblStokGirisAlt();
                    alt[i].GenelNo = int.Parse(txtGenelNo.Text);
                    alt[i].SiraNo = i + 1;
                    alt[i].Barkod = barkod;
                    alt[i].UrunKodu = Liste.Rows[i].Cells[2].Value.ToString();
                    alt[i].LotSeriNo = Liste.Rows[i].Cells[3].Value.ToString();
                    alt[i].Adet = int.Parse(Liste.Rows[i].Cells[4].Value.ToString());
                    alt[i].Not = Liste.Rows[i].Cells[5].Value.ToString();
                    alt[i].UT = DateTime.Parse(Liste.Rows[i].Cells[6].Value.ToString());
                    alt[i].SKT = DateTime.Parse(Liste.Rows[i].Cells[7].Value.ToString());
                    alt[i].AlisFiyat = decimal.Parse(Liste.Rows[i].Cells[8].Value.ToString());

                    //db.tblStokGirisAlt.Add(alt[i]);
                    //db.SaveChanges(); 
                    #endregion
                }

                db.tblStokGirisAlt.AddRange(alt);
                db.SaveChanges();
                MessageBox.Show("Kayit basarili...");

            }
            catch (Exception e)
            {
                MessageBox.Show("103" + "---" + e.Message);
            }
        }

        #region Butonlar

        protected override void OnLoad(EventArgs e)
        {
            var btnUrunGiris = new Button();
            btnUrunGiris.Size = new Size(25, txtGenelNo.ClientSize.Height + 2);
            btnUrunGiris.Location = new Point(txtGenelNo.ClientSize.Width - btnUrunGiris.Width, -1);
            btnUrunGiris.Cursor = Cursors.Default;
            btnUrunGiris.Image = Properties.Resources.arrow_1176;
            txtGenelNo.Controls.Add(btnUrunGiris);

            btnUrunGiris.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnYer = new Button();
            btnYer.Size = new Size(25, txtCariAdi.ClientSize.Height + 2);
            btnYer.Location = new Point(txtCariAdi.ClientSize.Width - btnYer.Width, -1);
            btnYer.Cursor = Cursors.Default;
            btnYer.Image = Properties.Resources.arrow_1176;
            txtCariAdi.Controls.Add(btnYer);

            btnYer.Anchor = (AnchorStyles.Top | AnchorStyles.Right);


            base.OnLoad(e);

            btnUrunGiris.Click += btnUrunGiris_Click;
            btnYer.Click += btnYer_Click;
            
        }

        

        private void btnYer_Click(object sender, EventArgs e)
        {
            if (txtCariGrup.Text=="Hastane")
            {
                int id = f.HastaneListesi(true);
                if (id>0)
                {
                    Ac(id);
                }

                Home.Aktarma = -1;
            }
            else if (txtCariGrup.Text=="Doktor")
            {
                int id = f.DoktorlarListesi(true);
                if (id > 0)
                {
                    Ac(id);
                }

                Home.Aktarma = -1;
            }
            else if (txtCariGrup.Text == "Personel")
            {
                int id = f.PersonellerListesi(true);
                if (id > 0)
                {
                    Ac(id);
                }

                Home.Aktarma = -1;
            }
            else if (txtCariGrup.Text == "Firma")
            {
                int id = f.FirmalarListesi(true);
                if (id > 0)
                {
                    Ac(id);
                }

                Home.Aktarma = -1;
            }
        }

        private void Ac(int id)
        {
            tblCariler bulId = db.tblCariler.Find(id);

            
            if (txtCariGrup.Text == "Personel")
            {
                bulId = db.tblPersonelDetay.First(x => x.Id == id).tblCariler;
            }
            

            try
            {
                tblCariler hst = bulId;
                txtCariAdi.Text = hst.CariAdi;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

       

        private void btnUrunGiris_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region DataGridView Islemleri
        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBox txt = e.Control as TextBox;

                if (Liste.CurrentCell.ColumnIndex == 2 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource.AddRange(MyArray);
                }
                else if (Liste.CurrentCell.ColumnIndex != 2 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("100" + ex.Message);
            }
        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    foreach (DataGridViewCell cell in Liste.SelectedCells)
                    {
                        int i = 0;
                        if (cell.Value != null)
                        {
                            string a = "";
                            if (Liste.CurrentRow != null)
                            {
                                a = Liste.CurrentRow.Cells[2].Value.ToString();
                            }
                            try
                            {
                                var lst = (from s in db.tblUrunler
                                           where s.UrunKodu == a
                                           select s).First();

                                //string ukod = lst.UrunKodu;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("101" + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Urun kodu bos olmamali!!");
                            if (Liste.CurrentRow != null) Liste.CurrentRow.Cells[2].Value = "";
                        }

                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("102" + ex.Message);
            }
        }
        #endregion

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }
    }
}
