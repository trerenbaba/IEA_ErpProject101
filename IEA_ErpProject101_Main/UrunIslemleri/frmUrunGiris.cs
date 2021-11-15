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
using IEA_ErpProject101_Main.Fonksiyonlar;

namespace IEA_ErpProject101_Main.UrunIslemleri
{
    public partial class frmUrunGiris : Form
    {
        private ErpProjectWMPEntities erp = new ErpProjectWMPEntities();

        private int secimId = -1;

        public frmUrunGiris()
        {
            InitializeComponent();
        }

        private void frmUrunGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblUrunler
                       where s.TedarikciFirmaId == 1
                       select s).ToList();

            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.UrunKodu;
                Liste.Rows[i].Cells[3].Value = k.UrunAdi;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ComboDoldur()
        {
            txtUrunTedarikciId.DataSource = (from s in erp.tblCariler
                                             where s.CariGroupId == 3
                                             where s.CariUnvan == "Distributor"
                                             select s).ToList();
            txtUrunTedarikciId.ValueMember = "Id";
            txtUrunTedarikciId.DisplayMember = "CariAdi";
            txtUrunTedarikciId.SelectedIndex = -1;
        }

        private void YeniKayit()
        {
            if (secimId!=-1 || txtUKodu.Text=="")
            {
                return;
            }
            try
            {
                tblUrunler urn = new tblUrunler();
                urn.UrunAdi = txtUAdi.Text;
                urn.TedarikciFirmaId = (int)txtUrunTedarikciId.SelectedValue;
                urn.UrunKodu = txtUKodu.Text;
                urn.AlisFiyat = decimal.Parse(txtUAlis.Text);
                urn.SatisFiyat = decimal.Parse(txtUSatis.Text);
                urn.KutuIcerik = txtUKutuIcerik.Text;
                urn.UrunGenelNo = txtKayitBul.Text;
                urn.UrunAciklama = txtUAciklama.Text;
                urn.SaveDate = DateTime.Now;
                urn.SaveUserId = 1;
                urn.isActive = true;

                erp.tblUrunler.Add(urn);
                erp.SaveChanges();

                MessageBox.Show("Kayit basarili");

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

         private tblUrunler urunler;
        private void Ac(int id)
        {
            urunler= erp.tblUrunler.Find(secimId);
            secimId = id;
            try
            {
                tblUrunler urn = urunler;
                txtUrunTedarikciId.Text = urn.tblCariler.CariAdi;
                txtKayitBul.Text = urn.UrunGenelNo;
                txtUKodu.Text = urn.UrunKodu;
                txtUAciklama.Text = urn.UrunAciklama;
                txtUAdi.Text = urn.UrunAdi;
                txtUAlis.Text = urn.AlisFiyat.ToString();
                txtUSatis.Text = urn.SatisFiyat.ToString();
                txtUKutuIcerik.Text = urn.KutuIcerik;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Guncelle()
        {
            if (secimId == -1)
            {
                return;
            }
            try
            {
                tblUrunler urn = urunler;
                urn.UrunAdi = txtUAdi.Text;
                urn.TedarikciFirmaId = (int)txtUrunTedarikciId.SelectedValue;
                urn.UrunKodu = txtUKodu.Text;
                urn.AlisFiyat = decimal.Parse(txtUAlis.Text);
                urn.SatisFiyat = decimal.Parse(txtUSatis.Text);
                urn.KutuIcerik = txtUKutuIcerik.Text;
                urn.UrunGenelNo = txtKayitBul.Text;
                urn.UrunAciklama = txtUAciklama.Text;
                urn.UpdateDate = DateTime.Now;
                urn.UpdateUserId = 1;

                erp.SaveChanges();

                MessageBox.Show("Guncelleme basarili");

                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
