﻿using IEA_ErpProject101_Main.Fonksiyonlar;
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
    public partial class frmStokGuncelle : Ortaklar
    {
        public frmStokGuncelle()
        {
            InitializeComponent();
        }

        private void frmStokGuncelle_Load(object sender, EventArgs e)
        {
            var lst = db.tblStokGirisAlt.Find(Home.Aktarma);
            txtGenelNo.Text = lst.GenelNo.ToString();
            txtAdet.Text = lst.Adet.ToString();
            txtAlisFiyat.Text = lst.AlisFiyat.ToString();
            txtBarkod.Text = lst.Barkod;
            txtLot.Text = lst.LotSeriNo;
            txtUrunKodu.Text = lst.UrunKodu;
            txtUT.Value = lst.UT.Value;
            txtSKT.Value = lst.SKT.Value;
        }

        
    }
}
