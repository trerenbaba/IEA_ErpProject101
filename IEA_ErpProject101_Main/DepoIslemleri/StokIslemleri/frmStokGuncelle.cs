﻿using System;
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

namespace IEA_ErpProject101_Main.DepoIslemleri.StokIslemleri
{
    public partial class frmStokGuncelle : Ortaklar
    {
        private int secimId = -1;
        public frmStokGuncelle()
        {
            InitializeComponent();
            
        }

        private void frmStokGuncelle_Load(object sender, EventArgs e)
        {
            txtUrunKodu.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();

            var drinst = db.tblUrunler.Where(x => x.isActive == true).Select(item => item.UrunKodu).Distinct();

            foreach (string urun in drinst)
            {
                veri.Add(urun);
                txtUrunKodu.Items.Add(urun);
            }
            txtUrunKodu.AutoCompleteCustomSource = veri;



            var lst = db.tblStokGirisAlt.Find(Home.Aktarma);
            lblGenelNo.Text = lst.GenelNo.ToString();
            txtAdet.Text = lst.Adet.ToString();
            txtAlisFiyat.Text = lst.AlisFiyat.ToString();
            txtBarkod.Text = lst.Barkod;
            txtLot.Text = lst.LotSeriNo;
            txtUrunKodu.Text = lst.UrunKodu;
            txtUt.Value = lst.UT.Value;
            txtSkt.Value = lst.SKT.Value;

            lblAdet.Text = lst.Adet.ToString();
            lblAlisFiyat.Text = lst.AlisFiyat.ToString();
            lblBarkod.Text = lst.Barkod;
            lblLot.Text = lst.LotSeriNo;
            lblUrunKodu.Text = lst.UrunKodu;
            lblUt.Text = lst.UT.ToString();
            lblSkt.Text = lst.SKT.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secimId = Home.Aktarma;
            Guncelle();
        }

        private void Guncelle()
        {
            if (lblBarkod.Text==txtBarkod.Text)
            {
                var srg = db.tblStokDurum.First(s => s.Barkod == lblBarkod.Text);
                if (srg != null)
                {
                    srg.StokAdet -= int.Parse(lblAdet.Text);
                    srg.RafAdet -= int.Parse(lblAdet.Text);
                    srg.StokAdet += int.Parse(txtAdet.Text);
                    srg.RafAdet += int.Parse(txtAdet.Text);

                }
                var lst = db.tblStokGirisAlt.First(s => s.Id == secimId);
                lst.UrunKodu = txtUrunKodu.Text;
                lst.AlisFiyat = Convert.ToDecimal(txtAlisFiyat.Text);
                lst.Barkod = txtBarkod.Text;
                lst.LotSeriNo = txtLot.Text;
                lst.SKT = txtSkt.Value;
                lst.UT = txtUt.Value;
                lst.Adet = Convert.ToInt32(txtAdet.Text);

                db.SaveChanges();
                MessageBox.Show("Güncelleme yapıldı.");
                Close(); 
            }
            else if (txtBarkod.Text!=lblBarkod.Text)
            {
                var varmi = db.tblStokDurum.Where(s => s.Barkod == txtBarkod.Text).ToString();
               
                if (varmi.Count() >0)
                {
                    var srg = db.tblStokDurum.First(s => s.Barkod == lblBarkod.Text);

                    if (srg != null)
                    {
                        srg.StokAdet -= int.Parse(lblAdet.Text);
                        srg.RafAdet -= int.Parse(lblAdet.Text);
                    }

                    var lst = db.tblStokGirisAlt.First(s => s.Id == secimId);

                    lst.UrunKodu = txtUrunKodu.Text;
                    lst.AlisFiyat = Convert.ToDecimal(txtAlisFiyat.Text);
                    lst.Barkod = txtBarkod.Text;
                    lst.LotSeriNo = txtLot.Text;
                    lst.SKT = txtSkt.Value;
                    lst.UT = txtUt.Value;
                    lst.Adet = Convert.ToInt32(txtAdet.Text);

                    var srg1 = db.tblStokDurum.First(s => s.Barkod == txtBarkod.Text);
                    if (srg1!=null)
                    {
                        srg1.StokAdet += int.Parse(txtAdet.Text);
                        srg1.RafAdet += int.Parse(txtAdet.Text);
                    }
                    db.SaveChanges();

                }
                else
                {
                    var srg = db.tblStokDurum.First(s => s.Barkod == lblBarkod.Text);

                    if (srg != null)
                    {
                        
                        srg.StokAdet -= int.Parse(lblAdet.Text);
                        srg.RafAdet -= int.Parse(lblAdet.Text);
                    }

                    tblStokDurum stk = new tblStokDurum();
                    stk.Barkod = txtBarkod.Text;
                    stk.RafAdet = int.Parse(txtAdet.Text);
                    stk.StokAdet = int.Parse(txtAdet.Text);
                    stk.KonsinyeAdet = 0;
                    stk.Lot = txtLot.Text;
                    stk.SKT = txtSkt.Value;
                    stk.UT = txtUt.Value;
                    stk.StokKodu = "1";
                    stk.SubeAdet = 0;
                    stk.Urun = txtUrunKodu.Text;

                    db.tblStokDurum.Add(stk);

                    var lst = db.tblStokGirisAlt.First(s => s.Id == secimId);

                    lst.UrunKodu = txtUrunKodu.Text;
                    lst.AlisFiyat = Convert.ToDecimal(txtAlisFiyat.Text);
                    lst.Barkod = txtBarkod.Text;
                    lst.LotSeriNo = txtLot.Text;
                    lst.SKT = txtSkt.Value;
                    lst.UT = txtUt.Value;
                    lst.Adet = Convert.ToInt32(txtAdet.Text);

                    db.SaveChanges();
                }
                
            }
        }

        private void txtUrunKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBarkod.Text = txtUrunKodu.Text + "/" + txtLot.Text;
            txtAdet.ReadOnly = true;
            txtBarkod.ReadOnly = true;
            TarihHesapla();
        }

        private void txtLot_TextChanged(object sender, EventArgs e)
        {
            txtBarkod.Text = txtUrunKodu.Text + "/" + txtLot.Text;
            txtAdet.ReadOnly = true;
            txtBarkod.ReadOnly = true;
        }

        private void txtUt_ValueChanged(object sender, EventArgs e)
        {
            TarihHesapla();
            
        }
        private void TarihHesapla()
        {
            int sure = (int)db.tblUrunler.First(s => s.UrunKodu == txtUrunKodu.Text).KullanimSuresiAy.Value;
            txtSkt.Value = txtUt.Value.AddMonths(sure);
            txtSkt.Enabled = false;
        }
    }
}
