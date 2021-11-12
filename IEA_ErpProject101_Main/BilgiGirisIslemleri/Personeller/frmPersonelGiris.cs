using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;
using IEA_ErpProject101_Main.Properties;

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Personeller
{
    public partial class frmPersonelGiris : Form
    {
        private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        private Numaralar n = new Numaralar();
        public int secimId = -1;

        public frmPersonelGiris()
        {
            InitializeComponent();
        }

        private void frmPersonelGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            int sira = 1;
            var lst = (from s in erp.tblPersonelDetay
                       where s.tblCariler.isActive == true
                       where s.tblCariler.CariGroupId == 6
                       select s).ToList();
                      

            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.tblCariler.CariNo;
                Liste.Rows[i].Cells[3].Value = k.tblCariler.CariAdi;
                Liste.Rows[i].Cells[4].Value = k.tblCariler.CariTel;
                Liste.Rows[i].Cells[5].Value = k.tblCariler.CariMail;
                Liste.Rows[i].Cells[6].Value = k.tblCariler.YetkiliCep1;
                Liste.Rows[i].Cells[7].Value = k.IsBasiTarih;
                Liste.Rows[i].Cells[8].Value = k.IsSonuTarih;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            lblPersonelKodu.Text = n.CariKoduHastane();
        }

        private void ComboDoldur()
        {
            var lst = erp.tblDepartmanlar.Where(x => x.GrupId == 6).ToList();
            var lst3 = erp.tblSehirler.ToList();

            txtPUnvan.DataSource = Enum.GetValues(typeof(enumPersonelUnvan));

            txtDepartman.DataSource = lst;
            txtDepartman.ValueMember = "Id";
            txtDepartman.DisplayMember = "DepartmanAdi";
            txtDepartman.SelectedIndex = -1;

            txtSehir.DataSource = lst3;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";
            txtSehir.SelectedIndex = -1;

        }

        private void YeniKayit()
        {
            string pkodu = n.CariKoduHastane();

            try
            {
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtPAdi.Text;
                    hst.CariMail = txtPMail.Text;
                    hst.CariTel = txtPTel.Text;
                    hst.YetkiliCep1 = txtPCep.Text;
                    hst.YetkiliDepartmani1 = txtDepartman.Text;             
                    hst.Adres1 = txtPAdres.Text;
                    hst.Adres2 = txtPAdres2.Text;
                    hst.CariGroupId = 6; 
                    hst.CariTipId = 1; //formda combobox olarak değiştir...
                    hst.CariUnvan = txtPUnvan.Text;                    
                    hst.Tc_Vn = txtTc.Text;
                    hst.SehirId = (int?)txtSehir.SelectedValue ?? -1; //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                    hst.SaveUserId = 1;
                    hst.SaveDate = DateTime.Now;
                    hst.CariNo = pkodu;
                    erp.tblCariler.Add(hst);
                    erp.SaveChanges();

                    tblPersonelDetay pdet = new tblPersonelDetay();
                    pdet.CariId = erp.tblCariler.First(x => x.CariAdi == txtPAdi.Text).Id;
                    pdet.IsBasiTarih = txtIsBasi.Value;
                   // pdet.IsSonuTarih = txtIsSonu.Value;
                    erp.tblPersonelDetay.Add(pdet);

                    erp.SaveChanges();
                    MessageBox.Show("Kayıt başarılı...");
                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Bu kayıt daha önce yapılmıştır. Kendine başka kayıt bul ...");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void Guncelle()
        {
            if (secimId<0)
            {
                return;
            }
            try
            {

                tblCariler prs = erp.tblCariler.Find(secimId);
                prs.isActive = true;
                prs.CariAdi = txtPAdi.Text;
                prs.CariMail = txtPMail.Text;
                prs.CariTel = txtPTel.Text;
                prs.YetkiliCep1 = txtPCep.Text;
                prs.YetkiliDepartmani1 = txtDepartman.Text;
               
                
                prs.Adres1 = txtPAdres.Text;
                prs.Adres2 = txtPAdres2.Text;

                prs.CariTipId = 1; //formda combobox olarak değiştir...
                prs.CariUnvan = txtPUnvan.Text;
               
                prs.Tc_Vn = txtTc.Text;
                prs.SehirId = (int?)txtSehir.SelectedValue ?? -1; //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                prs.UpdateUserId = 1;
                prs.UpdateDate = DateTime.Now;


                erp.SaveChanges();
                MessageBox.Show("Güncelleme başarılı...");
                Temizle();
                Listele();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }


        private void Temizle()
        {
            foreach (Control k in pnlOrta.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    k.Text = "";
                }
            }
            secimId = -1;
        }



        public void Ac(int id)
        {
            secimId = id; //dış formdan veri gelirse secimId hatası almamak için bu işlemi yaptım.
            try
            {
                tblPersonelDetay hst = erp.tblPersonelDetay.Find(id);
                txtPAdi.Text = hst.tblCariler.CariAdi;
                txtPMail.Text = hst.tblCariler.CariMail;
                txtPTel.Text = hst.tblCariler.CariTel;
                txtDepartman.Text = hst.tblCariler.YetkiliDepartmani1;
                txtPCep.Text = hst.tblCariler.YetkiliCep1;
                txtPAdres.Text = hst.tblCariler.Adres1;
                txtPAdres2.Text = hst.tblCariler.Adres2;
                txtPUnvan.Text = hst.tblCariler.CariUnvan;
                txtTc.Text = hst.tblCariler.Tc_Vn;
                txtSehir.Text = hst.tblCariler.tblSehirler == null ? "" : hst.tblCariler.tblSehirler.sehir;
                lblPersonelKodu.Text = hst.tblCariler.CariNo;
                txtKayitBul.Text = hst.tblCariler.CariNo;

                txtIsBasi.Text = hst.IsBasiTarih.ToString();
                txtIsSonu.Text = hst.IsSonuTarih.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, txtKayitBul.ClientSize.Height);
            btn.Location = new Point(txtKayitBul.ClientSize.Width - btn.Width);
            btn.Cursor = Cursors.Default;
            btn.Image = Resources.arrow_1176;
            txtKayitBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += btn_Click;
        }

        private void btn_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmHastanelerListesi"] == null)
            {
                frmHastanelerListesi frm = new frmHastanelerListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
