﻿using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.DepIslemleri.StokIslemleri
{
    public partial class frmStokGiris : Ortaklar
    {
        //ErpProjectWMPEntities db = new ErpProjectWMPEntities();
        //formlar f = new formlar();
        //Numaralar n = new Numaralar();

        public string[] MyArray { get; set; }
        private int secimGenelNo = -1;
        private int secimId = -1;

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

            //txtUrnCombo.DataSource = db.tblUrunler.ToList();
            //txtUrnCombo.ValueMember = "Id";
            //txtUrnCombo.DisplayMember = "UrunKodu";
            try
            {
                txtUrnCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
                var drinst = db.tblUrunler.Where(x => x.isActive == true).Select(item => item.UrunKodu).Distinct();
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
        void Topla()
        {
            try
            {
                int a = 0;
                for (int i = 0; i < Liste.Rows.Count; i++)
                {
                    a += Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                    txtToplam.Text = a.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void YeniKayit()
        {
            #region Stok giriş ust tablosuna kayit
            if (txtCariGrup.Text == "")
            {
                MessageBox.Show("Giriş türünü seçmediniz. Lütfen seçiniz.");
                return;
            }
            Liste.AllowUserToAddRows = false;
            try
            {
                tblStokGirisUst ust = new tblStokGirisUst
                {
                    GenelNo = int.Parse(txtGenelNo.Text),
                    CariGrupId = (int)txtCariGrup.SelectedValue,
                    CariAdiId = db.tblCariler.First(x => x.CariAdi == txtCariAdi.Text).Id,
                    GrisTipi = (int)(txtGirisTipi.SelectedValue),
                    FaturaNo = txtFaturaNo.Text,
                    FaturaTarih = txtGirisTarihi.Value,
                    Aciklama = txtAciklama.Text,
                    isActive = true,
                    SaveDate = DateTime.Now,
                    SaveUserId = 1,
                };
                db.tblStokGirisUst.Add(ust);
                //db.SaveChanges(); 
                #endregion

                tblStokDurum[] drm = new tblStokDurum[Liste.RowCount];
                tblStokGirisAlt[] alt = new tblStokGirisAlt[Liste.RowCount];


                for (int i = 0; i < Liste.RowCount; i++)
                {
                    string barkod = Liste.Rows[i].Cells[2].Value.ToString() + "/" + Liste.Rows[i].Cells[3].Value.ToString();

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
                        //db.SaveChanges();
                    }
                    else
                    {
                        tblStokDurum sdurum = db.tblStokDurum.First(x => x.Barkod == barkod);
                        sdurum.StokAdet += Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                        sdurum.RafAdet += Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                        // db.SaveChanges();
                    }
                    //db.tblStokDurum.AddRange(drm);
                    //db.SaveChanges();

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

                }
                db.tblStokGirisAlt.AddRange(alt);
                db.SaveChanges();
                MessageBox.Show("Kayıt başarılı...");
            }
            catch (Exception e)
            {
                MessageBox.Show("103" + " ---" + e.Message);
            }
        }



        private void Guncelle()
        {
            tblStokGirisUst ust = db.tblStokGirisUst.First(x => x.GenelNo == secimGenelNo);
            ust.GenelNo = int.Parse(txtGenelNo.Text);
            ust.CariGrupId = (int)txtCariGrup.SelectedValue;
            ust.CariAdiId = db.tblCariler.First(x => x.CariAdi == txtCariAdi.Text).Id;
            ust.GrisTipi = (int)txtGirisTipi.SelectedValue - 1;
            ust.FaturaNo = txtFaturaNo.Text;
            ust.FaturaTarih = txtGirisTarihi.Value;
            ust.Aciklama = txtAciklama.Text;
            ust.UpdateDate = DateTime.Now;
            ust.UpdateUserId = 1;

            //for (int i = 0; i < Liste2.RowCount; i++)
            //{
            //    string bar = Liste.Rows[i].Cells[1].Value.ToString();
            //    tblStokDurum sd = db.tblStokDurum.First(s => s.Barkod == bar);
            //    sd.StokAdet -= Convert.ToInt32(Liste2.Rows[i].Cells[4].Value.ToString());
            //    sd.RafAdet -= Convert.ToInt32(Liste2.Rows[i].Cells[4].Value.ToString());
            //    db.SaveChanges();
            //}

            //for (int i = 0; i < Liste.RowCount; i++)
            //{
            //    string bar = Liste.Rows[i].Cells[1].Value.ToString();
            //    tblStokDurum sd = db.tblStokDurum.First(s => s.Barkod == bar);
            //    sd.StokAdet += Convert.ToInt32(Liste.Rows[i].Cells[4].Value.ToString());
            //    sd.RafAdet += Convert.ToInt32(Liste.Rows[i].Cells[4].Value.ToString());
            //    db.SaveChanges();
            //}


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
            if (txtCariGrup.Text == "Hastane")
            {
                int id = f.HastaneListesi(true);
                if (id > 0)
                {
                    Ac(id);
                }
                Home.Aktarma = -1;
            }
            else if (txtCariGrup.Text == "Doktor")
            {
                int id = f.DoktorListesi(true);
                if (id > 0)
                {
                    Ac(id);
                }
            }
            else if (txtCariGrup.Text == "Personel")
            {
                int id = f.PersonelListesi(true);
                if (id > 0)
                {
                    Ac(id);
                }
            }
            else if (txtCariGrup.Text == "Firma")
            {
                int id = f.FirmaListesi(true);
                if (id > 0)
                {
                    Ac(id);
                }
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
            int id = f.StokGirisListesi(true);
            if (id > 0)
            {
                FormAc(id);

            }
            Home.Aktarma = -1;
        }

        private void FormAc(int id)
        {

            var kayitBul = db.tblStokGirisUst.Find(id);
            //var kayitBul1 = db.vwStokGiris.First(x => x.Id == id);
            secimGenelNo = kayitBul.GenelNo.Value;
            secimId = kayitBul.Id;
            //tblStokGirisUst ust = kayitBul;
            tblStokGirisUst ust = kayitBul;
            txtGenelNo.Text = ust.GenelNo.ToString();

            txtCariGrup.Text = ust.tblCariGruplari.GrupAdi;//ust.tblCariGruplari.GrupAdi;
            txtAciklama.Text = ust.Aciklama;
            txtFaturaNo.Text = ust.FaturaNo;
            txtCariAdi.Text = ust.tblCariler.CariAdi;//ust.tblCariler.CariAdi;
            if (ust.FaturaTarih != null) txtGirisTarihi.Value = (DateTime)ust.FaturaTarih;
            if (ust.GrisTipi != null) txtGirisTipi.SelectedIndex = ust.GrisTipi.Value;
            var alt = db.tblStokGirisAlt.Where(x => x.GenelNo.ToString() == txtGenelNo.Text);
            var alt1 = db.vwStokGiris.Where(x => x.GenelNo.ToString() == txtGenelNo.Text);
            int i = 0;
            Liste.Rows.Clear();
            Liste2.Rows.Clear();
            foreach (var k in alt1)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.SiraNo;
                Liste.Rows[i].Cells[1].Value = k.Barkod;
                Liste.Rows[i].Cells[2].Value = k.UrunKodu;
                Liste.Rows[i].Cells[3].Value = k.LotSeriNo;
                Liste.Rows[i].Cells[4].Value = k.Adet;
                Liste.Rows[i].Cells[5].Value = k.Not;
                Liste.Rows[i].Cells[6].Value = k.UT;
                Liste.Rows[i].Cells[7].Value = k.SKT;
                Liste.Rows[i].Cells[8].Value = k.AlisFiyat;
                Liste.Rows[i].Cells[9].Value = k.Id;

                Liste2.Rows.Add();
                Liste2.Rows[i].Cells[0].Value = k.SiraNo;
                Liste2.Rows[i].Cells[1].Value = k.Barkod;
                Liste2.Rows[i].Cells[2].Value = k.UrunKodu;
                Liste2.Rows[i].Cells[3].Value = k.LotSeriNo;
                Liste2.Rows[i].Cells[4].Value = k.Adet;
                Liste2.Rows[i].Cells[5].Value = k.Not;
                Liste2.Rows[i].Cells[6].Value = k.UT;
                Liste2.Rows[i].Cells[7].Value = k.SKT;
                Liste2.Rows[i].Cells[8].Value = k.AlisFiyat;

                i++;
            }

            Liste.AllowUserToAddRows = true;
            Liste2.AllowUserToAddRows = false;
            Liste.ReadOnly = false;
            Liste2.ReadOnly = true;
            Topla();
        }


        #endregion

        #region DataGridView İşlemleri
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
                MessageBox.Show(ex.Message);
            }
        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Topla();
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

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Ürün kodu boş olmamalı");
                            if (Liste.CurrentRow != null) Liste.CurrentRow.Cells[2].Value = "";
                        }
                        i++;
                    }
                }
                if (e.ColumnIndex == 6)
                {
                    if (Liste.CurrentRow.Cells[6].Value != null || Liste.CurrentRow.Cells[6].Value != "")
                    {
                        string a = Liste.CurrentRow.Cells[2].Value.ToString();
                        var lst = (from s in db.tblUrunler
                                   where s.UrunKodu == a
                                   select s).FirstOrDefault();
                        int ayy = lst.KullanımSuresiAy.Value;
                        DateTime ay = Convert.ToDateTime(Liste.CurrentRow.Cells[6].Value);
                        Liste.CurrentRow.Cells[7].Value = ay.AddMonths(ayy).ToShortDateString();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int)Liste.CurrentRow.Cells[9].Value;
            if (secimId>0)
            {
                Home.Aktarma = secimId;
                f.StokGuncelleAc();
            }
        }
    }
}
