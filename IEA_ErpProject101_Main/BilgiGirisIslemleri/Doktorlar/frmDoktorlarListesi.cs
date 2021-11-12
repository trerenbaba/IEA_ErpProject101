using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Hastaneler;
using IEA_ErpProject101_Main.Entity;

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar
{
    public partial class frmDoktorlarListesi : Form
    {
        readonly private ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        private int secimId = -1;
        public frmDoktorlarListesi()
        {
            InitializeComponent();
        }

        private void frmDoktorlarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true
                       where s.CariGroupId==2
                       select s).ToList();
            foreach (tblCariler k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.CariNo;
                Liste.Rows[i].Cells[3].Value = k.CariAdi;
                Liste.Rows[i].Cells[4].Value = k.CariTel;
                Liste.Rows[i].Cells[5].Value = k.CariMail;
                Liste.Rows[i].Cells[6].Value = k.YetkiliAdi1;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Application.OpenForms["frmDoktorGiris"] is null)
            {
                frmDoktorGiris frm = new frmDoktorGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Ac(secimId);
            }
            else if (Application.OpenForms["frmDoktorGiris"] != null)
            {
                frmDoktorGiris frm1 = Application.OpenForms["frmDoktorGiris"] as frmDoktorGiris;
                frm1.Ac(secimId);
            }
            this.Close();
        }
    }
}
