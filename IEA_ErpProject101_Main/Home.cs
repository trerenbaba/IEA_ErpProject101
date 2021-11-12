using IEA_ErpProject101_Main.BilgiGirisIslemleri;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Hastaneler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            MenuOlustur();
        }

        private void MenuOlustur()
        {
            #region Bilgi Giriş Menüsü
            tvBilgiGirisIslemleri.Nodes.Add("Hastaneler");
            tvBilgiGirisIslemleri.Nodes[0].Nodes.Add("Hastane Bilgi Giriş");
            tvBilgiGirisIslemleri.Nodes[0].Nodes.Add("Hastaneler Listesi");

            tvBilgiGirisIslemleri.Nodes.Add("Doktorlar");
            tvBilgiGirisIslemleri.Nodes[1].Nodes.Add("Doktor Bilgi Giriş");
            tvBilgiGirisIslemleri.Nodes[1].Nodes.Add("Doktorlar Listesi");

            tvBilgiGirisIslemleri.Nodes.Add("Cariler");
            tvBilgiGirisIslemleri.Nodes[2].Nodes.Add("Cari Bilgi Giriş");
            tvBilgiGirisIslemleri.Nodes[2].Nodes.Add("Cariler Listesi");
            #endregion

            #region Depo İşlemleri Menüsü
            tvDepoIslemleri.Nodes.Add("Depo İşlemleri");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Stok Durum");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Sevkiyat Listesi"); 
            #endregion


        }

        private void TvGorunum()
        {
            tvBilgiGirisIslemleri.Visible = false;
            tvDepoIslemleri.Visible = false;
            tv3.Visible = false;
            tv4.Visible = false;
            tv5.Visible = false;
            tv6.Visible = false;
            tv7.Visible = false;
            tv8.Visible = false;
            tv9.Visible = false;
            tv10.Visible = false;
            tv11.Visible = false;
            tv12.Visible = false;
        }
        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblBilgiEkrani.Text = btnBilgiGiris.Text;
            TvGorunum();
            tvBilgiGirisIslemleri.Visible = true;
        }

        private void btnDepoIslemleri_Click(object sender, EventArgs e)
        {
            lblBilgiEkrani.Text = btnDepoIslemleri.Text;
            TvGorunum();
            tvDepoIslemleri.Visible = true;
        }

        private void tvBilgiGirisIslemleri_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
        public static bool kontrol = false;

        private void tvBilgiGirisIslemleri_DoubleClick(object sender, EventArgs e)
        {

          
            //if (tvBilgiGirisIslemleri.SelectedNode !=null)
            //{
            //     isim = tvBilgiGirisIslemleri.SelectedNode.Text;
            //}
            string isim = tvBilgiGirisIslemleri.SelectedNode!=null? tvBilgiGirisIslemleri.SelectedNode.Text : "";

            if (isim == "Hastaneler Listesi" && Application.OpenForms["frmHastanelerListesi"] is null) //kontrol == false
            {
                frmHastanelerListesi frm = new frmHastanelerListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Activate();
                //kontrol = true;
            }
            else if (isim == "Hastane Bilgi Giriş" && Application.OpenForms["frmHastaneGiris"] is null)  //kontrol==false
            {
                frmHastaneGiris frm = new frmHastaneGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                //kontrol = true;
            }
            else if (isim == "Doktor Bilgi Giriş" && Application.OpenForms["frmDoktorGiris"] is null)
            {
                frmDoktorGiris frm = new frmDoktorGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            else if (isim == "Doktorlar Listesi" && Application.OpenForms["frmDoktorlarListesi"] is null)
            {
                frmDoktorlarListesi frm = new frmDoktorlarListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }


        }
    }
}
