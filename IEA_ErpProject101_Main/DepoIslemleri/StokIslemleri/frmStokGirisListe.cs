using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject101_Main.Fonksiyonlar;

namespace IEA_ErpProject101_Main.DepoIslemleri.StokIslemleri
{
    public partial class frmStokGirisListe : Ortaklar
    {
        public bool Secim = false;
        public frmStokGirisListe()
        {
            InitializeComponent();
        }

        private void frmStokGirisListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()/////En Son Burada Kaldik burayi duzelt!!!!
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in db.tblCariler
                where s.isActive == true
                where s.CariGroupId == 2
                select new
                {
                    id = s.Id,
                    hcode = s.CariNo,
                    hadi = s.CariAdi,
                    htel = s.CariTel,
                    hmail = s.CariMail,
                    hyetcep = s.YetkiliCep1
                }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.hcode;
                Liste.Rows[i].Cells[3].Value = k.hadi;
                Liste.Rows[i].Cells[4].Value = k.htel;
                Liste.Rows[i].Cells[5].Value = k.hmail;
                Liste.Rows[i].Cells[6].Value = k.hyetcep;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
        }
    }
}
