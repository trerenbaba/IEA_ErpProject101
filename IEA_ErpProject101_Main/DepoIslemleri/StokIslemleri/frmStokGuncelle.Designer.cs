
namespace IEA_ErpProject101_Main.DepoIslemleri.StokIslemleri
{
    partial class frmStokGuncelle
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
            this.txtLot = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUt = new System.Windows.Forms.DateTimePicker();
            this.txtSkt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGenelNo = new System.Windows.Forms.Label();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.lblLot = new System.Windows.Forms.Label();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblUt = new System.Windows.Forms.Label();
            this.lblSkt = new System.Windows.Forms.Label();
            this.lblAlisFiyat = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtUrunKodu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(122, 72);
            this.txtLot.Margin = new System.Windows.Forms.Padding(2);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(110, 20);
            this.txtLot.TabIndex = 0;
            this.txtLot.TextChanged += new System.EventHandler(this.txtLot_TextChanged);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(236, 72);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(110, 20);
            this.txtBarkod.TabIndex = 0;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(349, 72);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(110, 20);
            this.txtAdet.TabIndex = 0;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(659, 72);
            this.txtAlisFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(110, 20);
            this.txtAlisFiyat.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Urun Kodu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(122, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lot/Seri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(236, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barkod";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(349, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adet";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(657, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alis Fiyat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUt
            // 
            this.txtUt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtUt.Location = new System.Drawing.Point(462, 72);
            this.txtUt.Margin = new System.Windows.Forms.Padding(2);
            this.txtUt.Name = "txtUt";
            this.txtUt.Size = new System.Drawing.Size(95, 20);
            this.txtUt.TabIndex = 5;
            this.txtUt.ValueChanged += new System.EventHandler(this.txtUt_ValueChanged);
            // 
            // txtSkt
            // 
            this.txtSkt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtSkt.Location = new System.Drawing.Point(561, 72);
            this.txtSkt.Margin = new System.Windows.Forms.Padding(2);
            this.txtSkt.Name = "txtSkt";
            this.txtSkt.Size = new System.Drawing.Size(95, 20);
            this.txtSkt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(460, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "UT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(560, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "SKT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Genel No";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenelNo
            // 
            this.lblGenelNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblGenelNo.Location = new System.Drawing.Point(124, 9);
            this.lblGenelNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenelNo.Name = "lblGenelNo";
            this.lblGenelNo.Size = new System.Drawing.Size(109, 16);
            this.lblGenelNo.TabIndex = 9;
            this.lblGenelNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUrunKodu.Location = new System.Drawing.Point(6, 31);
            this.lblUrunKodu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(109, 16);
            this.lblUrunKodu.TabIndex = 10;
            this.lblUrunKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLot
            // 
            this.lblLot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLot.Location = new System.Drawing.Point(124, 30);
            this.lblLot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(109, 16);
            this.lblLot.TabIndex = 9;
            this.lblLot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBarkod
            // 
            this.lblBarkod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBarkod.Location = new System.Drawing.Point(237, 30);
            this.lblBarkod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(108, 16);
            this.lblBarkod.TabIndex = 12;
            this.lblBarkod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdet
            // 
            this.lblAdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAdet.Location = new System.Drawing.Point(349, 29);
            this.lblAdet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(109, 16);
            this.lblAdet.TabIndex = 11;
            this.lblAdet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUt
            // 
            this.lblUt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUt.Location = new System.Drawing.Point(462, 29);
            this.lblUt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUt.Name = "lblUt";
            this.lblUt.Size = new System.Drawing.Size(94, 16);
            this.lblUt.TabIndex = 13;
            this.lblUt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSkt
            // 
            this.lblSkt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSkt.Location = new System.Drawing.Point(562, 29);
            this.lblSkt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSkt.Name = "lblSkt";
            this.lblSkt.Size = new System.Drawing.Size(94, 16);
            this.lblSkt.TabIndex = 14;
            this.lblSkt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlisFiyat
            // 
            this.lblAlisFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAlisFiyat.Location = new System.Drawing.Point(659, 29);
            this.lblAlisFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlisFiyat.Name = "lblAlisFiyat";
            this.lblAlisFiyat.Size = new System.Drawing.Size(107, 16);
            this.lblAlisFiyat.TabIndex = 14;
            this.lblAlisFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(679, 97);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(73, 51);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUrunKodu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUrunKodu.FormattingEnabled = true;
            this.txtUrunKodu.Location = new System.Drawing.Point(9, 72);
            this.txtUrunKodu.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(109, 21);
            this.txtUrunKodu.TabIndex = 17;
            this.txtUrunKodu.SelectedIndexChanged += new System.EventHandler(this.txtUrunKodu_SelectedIndexChanged);
            // 
            // frmStokGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 160);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblAlisFiyat);
            this.Controls.Add(this.lblSkt);
            this.Controls.Add(this.lblUt);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblUrunKodu);
            this.Controls.Add(this.lblLot);
            this.Controls.Add(this.lblGenelNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSkt);
            this.Controls.Add(this.txtUt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlisFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txtLot);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStokGuncelle";
            this.Text = "frmStokGuncelle";
            this.Load += new System.EventHandler(this.frmStokGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtLot;
        public System.Windows.Forms.TextBox txtBarkod;
        public System.Windows.Forms.TextBox txtAdet;
        public System.Windows.Forms.TextBox txtAlisFiyat;
        private System.Windows.Forms.DateTimePicker txtUt;
        private System.Windows.Forms.DateTimePicker txtSkt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGenelNo;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.Label lblLot;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblUt;
        private System.Windows.Forms.Label lblSkt;
        private System.Windows.Forms.Label lblAlisFiyat;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox txtUrunKodu;
    }
}