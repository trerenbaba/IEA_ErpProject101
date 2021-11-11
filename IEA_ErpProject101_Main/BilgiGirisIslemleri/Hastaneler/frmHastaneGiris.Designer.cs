
namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Hastaneler
{
    partial class frmHastaneGiris
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblHastaneKodu = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YetkiliAdi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtYet1 = new System.Windows.Forms.TextBox();
            this.txtYet2 = new System.Windows.Forms.TextBox();
            this.txtYet3 = new System.Windows.Forms.TextBox();
            this.txtDepartman1 = new System.Windows.Forms.ComboBox();
            this.txtDepartman2 = new System.Windows.Forms.ComboBox();
            this.txtDepartman3 = new System.Windows.Forms.ComboBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.txtEmail3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHastaneAdi = new System.Windows.Forms.TextBox();
            this.txtHastaneCari = new System.Windows.Forms.TextBox();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.txtAdres2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHastaneMail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtYcep1 = new System.Windows.Forms.MaskedTextBox();
            this.txtYcep2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYcep3 = new System.Windows.Forms.MaskedTextBox();
            this.txtYtel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtYtel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYtel3 = new System.Windows.Forms.MaskedTextBox();
            this.txtHasTel = new System.Windows.Forms.MaskedTextBox();
            this.txtVnTc = new System.Windows.Forms.MaskedTextBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtKayitBul = new System.Windows.Forms.TextBox();
            this.txtCariTip = new System.Windows.Forms.ComboBox();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblHastaneKodu);
            this.pnlUst.Controls.Add(this.btnKaydet);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnFormCikis);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(955, 67);
            this.pnlUst.TabIndex = 0;
            // 
            // lblHastaneKodu
            // 
            this.lblHastaneKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHastaneKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneKodu.Location = new System.Drawing.Point(344, 21);
            this.lblHastaneKodu.Name = "lblHastaneKodu";
            this.lblHastaneKodu.Size = new System.Drawing.Size(510, 39);
            this.lblHastaneKodu.TabIndex = 1;
            this.lblHastaneKodu.Text = "***";
            this.lblHastaneKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Save_icon64x64;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(25, 8);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(65, 52);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(98, 8);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(65, 52);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnFormCikis
            // 
            this.btnFormCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormCikis.BackColor = System.Drawing.SystemColors.Control;
            this.btnFormCikis.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.exit_64;
            this.btnFormCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormCikis.Location = new System.Drawing.Point(899, 12);
            this.btnFormCikis.Name = "btnFormCikis";
            this.btnFormCikis.Size = new System.Drawing.Size(44, 44);
            this.btnFormCikis.TabIndex = 2;
            this.btnFormCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormCikis.UseVisualStyleBackColor = false;
            this.btnFormCikis.Click += new System.EventHandler(this.btnFormCikis_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Sil24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(169, 8);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(65, 52);
            this.btnSil.TabIndex = 0;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Sil64;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTemizle.Location = new System.Drawing.Point(240, 8);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(65, 52);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 485);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(955, 17);
            this.pnlAlt.TabIndex = 1;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.CariKodu,
            this.CariAdi,
            this.CariTel,
            this.CariMail,
            this.YetkiliAdi1});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 381);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(955, 104);
            this.Liste.TabIndex = 2;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sıra";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // CariKodu
            // 
            this.CariKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariKodu.HeaderText = "Hastane Kodu";
            this.CariKodu.Name = "CariKodu";
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Hastane Adı";
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Hastane Tel";
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 90;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Hastane Mail";
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 94;
            // 
            // YetkiliAdi1
            // 
            this.YetkiliAdi1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.YetkiliAdi1.HeaderText = "YetkiliKisi";
            this.YetkiliAdi1.Name = "YetkiliAdi1";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Red;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 371);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(955, 10);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hastane Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hastane Cari";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(20, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adres1 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(499, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Adres 2 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(307, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cari Tipi :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(304, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Yetkili";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(799, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "E-Mail";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(421, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Departman";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(559, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Telefon";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(681, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cep";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYet1
            // 
            this.txtYet1.Location = new System.Drawing.Point(304, 47);
            this.txtYet1.Name = "txtYet1";
            this.txtYet1.Size = new System.Drawing.Size(104, 20);
            this.txtYet1.TabIndex = 10;
            // 
            // txtYet2
            // 
            this.txtYet2.Location = new System.Drawing.Point(304, 70);
            this.txtYet2.Name = "txtYet2";
            this.txtYet2.Size = new System.Drawing.Size(104, 20);
            this.txtYet2.TabIndex = 15;
            // 
            // txtYet3
            // 
            this.txtYet3.Location = new System.Drawing.Point(304, 96);
            this.txtYet3.Name = "txtYet3";
            this.txtYet3.Size = new System.Drawing.Size(104, 20);
            this.txtYet3.TabIndex = 20;
            // 
            // txtDepartman1
            // 
            this.txtDepartman1.FormattingEnabled = true;
            this.txtDepartman1.Location = new System.Drawing.Point(424, 46);
            this.txtDepartman1.Name = "txtDepartman1";
            this.txtDepartman1.Size = new System.Drawing.Size(104, 21);
            this.txtDepartman1.TabIndex = 11;
            // 
            // txtDepartman2
            // 
            this.txtDepartman2.FormattingEnabled = true;
            this.txtDepartman2.Location = new System.Drawing.Point(424, 69);
            this.txtDepartman2.Name = "txtDepartman2";
            this.txtDepartman2.Size = new System.Drawing.Size(104, 21);
            this.txtDepartman2.TabIndex = 16;
            // 
            // txtDepartman3
            // 
            this.txtDepartman3.FormattingEnabled = true;
            this.txtDepartman3.Location = new System.Drawing.Point(424, 95);
            this.txtDepartman3.Name = "txtDepartman3";
            this.txtDepartman3.Size = new System.Drawing.Size(104, 21);
            this.txtDepartman3.TabIndex = 21;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(799, 52);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(148, 20);
            this.txtEmail1.TabIndex = 14;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(799, 75);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(148, 20);
            this.txtEmail2.TabIndex = 19;
            // 
            // txtEmail3
            // 
            this.txtEmail3.Location = new System.Drawing.Point(799, 101);
            this.txtEmail3.Name = "txtEmail3";
            this.txtEmail3.Size = new System.Drawing.Size(148, 20);
            this.txtEmail3.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(38, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Vergi Dairesi :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(307, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "Vergi No :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(122, 250);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(160, 20);
            this.txtVergiDairesi.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(17, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Hastane Tel :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHastaneAdi
            // 
            this.txtHastaneAdi.Location = new System.Drawing.Point(117, 52);
            this.txtHastaneAdi.Name = "txtHastaneAdi";
            this.txtHastaneAdi.Size = new System.Drawing.Size(159, 20);
            this.txtHastaneAdi.TabIndex = 0;
            // 
            // txtHastaneCari
            // 
            this.txtHastaneCari.Location = new System.Drawing.Point(117, 76);
            this.txtHastaneCari.Name = "txtHastaneCari";
            this.txtHastaneCari.Size = new System.Drawing.Size(159, 20);
            this.txtHastaneCari.TabIndex = 1;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(120, 153);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(286, 51);
            this.txtAdres1.TabIndex = 4;
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(571, 128);
            this.txtAdres2.Multiline = true;
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Size = new System.Drawing.Size(376, 50);
            this.txtAdres2.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(17, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 18);
            this.label15.TabIndex = 4;
            this.label15.Text = "Hastane Mail :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHastaneMail
            // 
            this.txtHastaneMail.Location = new System.Drawing.Point(117, 122);
            this.txtHastaneMail.Name = "txtHastaneMail";
            this.txtHastaneMail.Size = new System.Drawing.Size(159, 20);
            this.txtHastaneMail.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(36, 224);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Şehir :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(120, 224);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(162, 21);
            this.txtSehir.TabIndex = 6;
            // 
            // txtYcep1
            // 
            this.txtYcep1.Location = new System.Drawing.Point(684, 52);
            this.txtYcep1.Mask = "(999) 000-0000";
            this.txtYcep1.Name = "txtYcep1";
            this.txtYcep1.Size = new System.Drawing.Size(96, 20);
            this.txtYcep1.TabIndex = 13;
            // 
            // txtYcep2
            // 
            this.txtYcep2.Location = new System.Drawing.Point(684, 75);
            this.txtYcep2.Mask = "(999) 000-0000";
            this.txtYcep2.Name = "txtYcep2";
            this.txtYcep2.Size = new System.Drawing.Size(96, 20);
            this.txtYcep2.TabIndex = 18;
            // 
            // txtYcep3
            // 
            this.txtYcep3.Location = new System.Drawing.Point(684, 101);
            this.txtYcep3.Mask = "(999) 000-0000";
            this.txtYcep3.Name = "txtYcep3";
            this.txtYcep3.Size = new System.Drawing.Size(96, 20);
            this.txtYcep3.TabIndex = 23;
            // 
            // txtYtel1
            // 
            this.txtYtel1.Location = new System.Drawing.Point(564, 48);
            this.txtYtel1.Mask = "(999) 000-0000";
            this.txtYtel1.Name = "txtYtel1";
            this.txtYtel1.Size = new System.Drawing.Size(94, 20);
            this.txtYtel1.TabIndex = 12;
            // 
            // txtYtel2
            // 
            this.txtYtel2.Location = new System.Drawing.Point(564, 71);
            this.txtYtel2.Mask = "(999) 000-0000";
            this.txtYtel2.Name = "txtYtel2";
            this.txtYtel2.Size = new System.Drawing.Size(94, 20);
            this.txtYtel2.TabIndex = 17;
            // 
            // txtYtel3
            // 
            this.txtYtel3.Location = new System.Drawing.Point(564, 97);
            this.txtYtel3.Mask = "(999) 000-0000";
            this.txtYtel3.Name = "txtYtel3";
            this.txtYtel3.Size = new System.Drawing.Size(94, 20);
            this.txtYtel3.TabIndex = 22;
            // 
            // txtHasTel
            // 
            this.txtHasTel.Location = new System.Drawing.Point(117, 99);
            this.txtHasTel.Mask = "(999) 000-0000";
            this.txtHasTel.Name = "txtHasTel";
            this.txtHasTel.Size = new System.Drawing.Size(93, 20);
            this.txtHasTel.TabIndex = 2;
            // 
            // txtVnTc
            // 
            this.txtVnTc.Location = new System.Drawing.Point(422, 249);
            this.txtVnTc.Mask = "00000999999";
            this.txtVnTc.Name = "txtVnTc";
            this.txtVnTc.Size = new System.Drawing.Size(104, 20);
            this.txtVnTc.TabIndex = 9;
            // 
            // pnlOrta
            // 
            this.pnlOrta.AutoScroll = true;
            this.pnlOrta.Controls.Add(this.txtKayitBul);
            this.pnlOrta.Controls.Add(this.txtCariTip);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtVnTc);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.txtHasTel);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.txtYtel3);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.txtYcep3);
            this.pnlOrta.Controls.Add(this.txtYtel2);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtYcep2);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.txtYtel1);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtYcep1);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.txtDepartman3);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtDepartman2);
            this.pnlOrta.Controls.Add(this.label10);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.label11);
            this.pnlOrta.Controls.Add(this.txtDepartman1);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.txtEmail3);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.txtYet3);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.txtEmail2);
            this.pnlOrta.Controls.Add(this.label9);
            this.pnlOrta.Controls.Add(this.txtYet2);
            this.pnlOrta.Controls.Add(this.txtYet1);
            this.pnlOrta.Controls.Add(this.txtVergiDairesi);
            this.pnlOrta.Controls.Add(this.txtHastaneAdi);
            this.pnlOrta.Controls.Add(this.txtEmail1);
            this.pnlOrta.Controls.Add(this.txtHastaneCari);
            this.pnlOrta.Controls.Add(this.txtHastaneMail);
            this.pnlOrta.Controls.Add(this.txtAdres1);
            this.pnlOrta.Controls.Add(this.txtAdres2);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 67);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(955, 304);
            this.pnlOrta.TabIndex = 10;
            // 
            // txtKayitBul
            // 
            this.txtKayitBul.Location = new System.Drawing.Point(11, 6);
            this.txtKayitBul.Name = "txtKayitBul";
            this.txtKayitBul.Size = new System.Drawing.Size(223, 20);
            this.txtKayitBul.TabIndex = 27;
            // 
            // txtCariTip
            // 
            this.txtCariTip.FormattingEnabled = true;
            this.txtCariTip.Location = new System.Drawing.Point(422, 221);
            this.txtCariTip.Name = "txtCariTip";
            this.txtCariTip.Size = new System.Drawing.Size(121, 21);
            this.txtCariTip.TabIndex = 26;
            // 
            // frmHastaneGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 502);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmHastaneGiris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHastaneGiris_FormClosing);
            this.Load += new System.EventHandler(this.frmHastaneGiris_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtYet1;
        private System.Windows.Forms.TextBox txtYet2;
        private System.Windows.Forms.TextBox txtYet3;
        private System.Windows.Forms.ComboBox txtDepartman1;
        private System.Windows.Forms.ComboBox txtDepartman2;
        private System.Windows.Forms.ComboBox txtDepartman3;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.TextBox txtEmail3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHastaneAdi;
        private System.Windows.Forms.TextBox txtHastaneCari;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.TextBox txtAdres2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtHastaneMail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.MaskedTextBox txtYcep1;
        private System.Windows.Forms.MaskedTextBox txtYcep2;
        private System.Windows.Forms.MaskedTextBox txtYcep3;
        private System.Windows.Forms.MaskedTextBox txtYtel1;
        private System.Windows.Forms.MaskedTextBox txtYtel2;
        private System.Windows.Forms.MaskedTextBox txtYtel3;
        private System.Windows.Forms.MaskedTextBox txtHasTel;
        private System.Windows.Forms.MaskedTextBox txtVnTc;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiliAdi1;
        private System.Windows.Forms.Label lblHastaneKodu;
        private System.Windows.Forms.ComboBox txtCariTip;
        private System.Windows.Forms.TextBox txtKayitBul;
    }
}