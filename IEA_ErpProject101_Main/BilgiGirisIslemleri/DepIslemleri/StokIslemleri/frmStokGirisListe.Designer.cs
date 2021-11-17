
namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.DepIslemleri.StokIslemleri
{
    partial class frmStokGirisListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot_SeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlisFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(890, 47);
            this.pnlUst.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(687, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(203, 47);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Form Çıkış";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stok Giriş Kartı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Liste
            // 
            this.Liste.AllowDrop = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Liste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.barcode,
            this.Ukod,
            this.Lot_SeriNo,
            this.GAdet,
            this.Not,
            this.UTarih,
            this.SKTarih,
            this.AlisFiyat});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 47);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Liste.Size = new System.Drawing.Size(890, 433);
            this.Liste.TabIndex = 4;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            this.Sira.Visible = false;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barkod";
            this.barcode.Name = "barcode";
            this.barcode.Visible = false;
            // 
            // Ukod
            // 
            this.Ukod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ukod.HeaderText = "Ürün Kodu";
            this.Ukod.Name = "Ukod";
            // 
            // Lot_SeriNo
            // 
            this.Lot_SeriNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Lot_SeriNo.HeaderText = "Lot / Seri No";
            this.Lot_SeriNo.Name = "Lot_SeriNo";
            this.Lot_SeriNo.Width = 93;
            // 
            // GAdet
            // 
            this.GAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GAdet.HeaderText = "Giris Adet";
            this.GAdet.Name = "GAdet";
            this.GAdet.Width = 77;
            // 
            // Not
            // 
            this.Not.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Not.HeaderText = "Not";
            this.Not.Name = "Not";
            // 
            // UTarih
            // 
            this.UTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "-";
            this.UTarih.DefaultCellStyle = dataGridViewCellStyle2;
            this.UTarih.HeaderText = "UT";
            this.UTarih.Name = "UTarih";
            this.UTarih.Width = 47;
            // 
            // SKTarih
            // 
            this.SKTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = "-";
            this.SKTarih.DefaultCellStyle = dataGridViewCellStyle3;
            this.SKTarih.HeaderText = "SKT";
            this.SKTarih.Name = "SKTarih";
            this.SKTarih.Width = 53;
            // 
            // AlisFiyat
            // 
            this.AlisFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AlisFiyat.HeaderText = "Alış Fiyatı";
            this.AlisFiyat.Name = "AlisFiyat";
            this.AlisFiyat.Width = 75;
            // 
            // frmStokGirisListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 480);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmStokGirisListe";
            this.Text = "frmStokGirisListe";
            this.Load += new System.EventHandler(this.frmStokGirisListe_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lot_SeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Not;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlisFiyat;
    }
}