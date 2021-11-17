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
using IEA_ErpProject101_Main.Entity;

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar
{
    public partial class frmDoktorGiris : Ortaklar
    {
       // readonly private ErpProjectWMPEntities db = new ErpProjectWMPEntities();
        public  int secimId = -1;
        //private Numaralar n = new Numaralar();
        private tblCariler idyeGoreBul;

        public frmDoktorGiris()
        {
            InitializeComponent();
        }

        private void frmDoktorGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {
            var lst = db.tblDepartmanlar.Where(x => x.GrupId == 2).ToList();
            var lst2 = db.tblSehirler.ToList();
            txtDUnvan.DataSource = Enum.GetValues(typeof(DoktorUnvan));

            txtDepartman.DataSource = lst;
            txtDepartman.ValueMember = "Id";
            txtDepartman.DisplayMember = "DepartmanAdi";
            txtDepartman.SelectedIndex = -1;

            txtSehir.DataSource = lst2;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";
            txtSehir.SelectedIndex = -1;


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            int sira = 1;
            var lst = (from s in db.tblCariler
                       where s.isActive == true
                       where s.CariGroupId==2
                       select new
                       {
                           id = s.Id,
                           dcode = s.CariNo,
                           dadi = s.CariAdi,
                           dtel = s.CariTel,
                           dmail = s.CariMail,
                           dgsm = s.YetkiliTel1,
                       }).ToList();

            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.dcode;
                Liste.Rows[i].Cells[3].Value = k.dadi;
                Liste.Rows[i].Cells[4].Value = k.dtel;
                Liste.Rows[i].Cells[5].Value = k.dmail;
                Liste.Rows[i].Cells[6].Value = k.dgsm;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            lblHastaneKodu.Text = n.CariKoduDoktor();
        }

        private void YeniKayit()
        {
            string hkodu = n.CariKoduDoktor();

            try
            {
                if (secimId == -1)
                {
                    tblCariler hst   = new tblCariler();
                    hst.isActive     = true;
                    hst.CariAdi      = txtDAdi.Text;
                    hst.CariMail     = txtDMail.Text;
                    hst.CariTel      = txtDTel.Text;
                    hst.YetkiliTel1  = txtDCep.Text;
                    hst.YetkiliDepartmani1 = txtDepartman.Text;
                    
                   
                    hst.Adres1      = txtDHastAdres.Text;
                    hst.Adres2      = txtDMuAdres.Text;
                    hst.CariGroupId = 2;
                    hst.CariTipId   = 1; //formda combobox olarak değiştir...
                    hst.CariUnvan   = txtDUnvan.Text;
                    hst.Vdairesi     = txtVergiDairesi.Text;
                    hst.Tc_Vn       = txtVnTc.Text;
                    if (txtSehir.Text != "")
                    {
                        hst.SehirId = (int?)txtSehir.SelectedValue ?? -1; //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id; 
                    }
                    hst.SaveUserId  = 1;
                    hst.SaveDate    = DateTime.Now;
                    hst.CariNo      = hkodu;

                    db.tblCariler.Add(hst);
                    db.SaveChanges();
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            try
            {
                tblCariler dr = idyeGoreBul;            
                dr.CariAdi = txtDAdi.Text;
                dr.CariMail = txtDMail.Text;
                dr.CariTel = txtDTel.Text;
                dr.YetkiliTel1 = txtDCep.Text;

                dr.Adres1 = txtDHastAdres.Text;
                dr.Adres2 = txtDMuAdres.Text;
                dr.YetkiliDepartmani1 = txtDepartman.Text;
                dr.CariTipId = 1;
                dr.CariUnvan = txtDUnvan.Text;
                dr.Vdairesi = txtVergiDairesi.Text;
                dr.Tc_Vn = txtVnTc.Text;
                dr.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                dr.SaveUserId = 1;
                dr.UpdateUserId = 1;
                dr.UpdateDate = DateTime.Now;
                
                db.SaveChanges();
                MessageBox.Show("Güncelleme başarılı...");
                Temizle();
                Listele();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }
        public void Ac(int id)
        {
            secimId = id; //dış formdan veri gelirse secimId hatası almamak için bu işlemi yaptım.
            idyeGoreBul = db.tblCariler.Find(id);
            try
            {
                tblCariler dr = idyeGoreBul;
                txtDAdi.Text = dr.CariAdi;
                txtDMail.Text = dr.CariMail;
                txtDTel.Text = dr.CariTel;
                txtDCep.Text = dr.YetkiliTel1;
                txtDHastAdres.Text = dr.Adres1;
                txtDMuAdres.Text = dr.Adres2;
                txtDUnvan.Text = dr.CariUnvan;
                txtVergiDairesi.Text = dr.Vdairesi;
                txtVnTc.Text = dr.Tc_Vn;
                txtDepartman.Text = dr.YetkiliDepartmani1;
                txtSehir.Text = dr.tblSehirler==null? "": dr.tblSehirler.sehir; 

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblCariler dr = idyeGoreBul;
                dr.isActive = false;
                db.SaveChanges();
                MessageBox.Show("Silme Başarılı");
                Temizle();
                Listele();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
