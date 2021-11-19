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
    public partial class frmStokGirisListe : Ortaklar
    {
        public bool Secim = false;
        private int secimId = -1;
        public frmStokGirisListe()
        {
            InitializeComponent();
        }

        private void frmStokGirisListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {

            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in db.tblStokGirisUst
                       where s.isActive == true
                       select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.GenelNo;
                Liste.Rows[i].Cells[2].Value = k.tblCariler.CariAdi;
                Liste.Rows[i].Cells[3].Value = k.FaturaNo;
                Liste.Rows[i].Cells[4].Value = k.FaturaTarih;
                Liste.Rows[i].Cells[5].Value = k.GrisTipi;

                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Secim)
            {
                Home.Aktarma = secimId;
                Close();
            }


        }
    }
}
