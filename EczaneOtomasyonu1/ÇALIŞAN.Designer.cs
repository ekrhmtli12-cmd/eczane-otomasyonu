namespace EczaneOtomasyonu1
{
    partial class ÇALIŞAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÇALIŞAN));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOSYAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dÜZENLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtKayitTarihi = new System.Windows.Forms.TextBox();
            this.cmbKurum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textstok_adı = new System.Windows.Forms.ComboBox();
            this.txtStokAdedi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KULLANICI_ADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KULLANICI_SOYADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KULLANICI_TELEFON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAĞLI_OLDUĞU_KURUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KAYIT_TARİHİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İLACIN_ADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOK_ADEDİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FİYAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TUTAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.butonilaçsatıç_hastakontrol_Click = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbIlacAdi = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOSYAToolStripMenuItem,
            this.dÜZENLEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dOSYAToolStripMenuItem
            // 
            this.dOSYAToolStripMenuItem.Name = "dOSYAToolStripMenuItem";
            this.dOSYAToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.dOSYAToolStripMenuItem.Text = "DOSYA";
            // 
            // dÜZENLEToolStripMenuItem
            // 
            this.dÜZENLEToolStripMenuItem.Name = "dÜZENLEToolStripMenuItem";
            this.dÜZENLEToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.dÜZENLEToolStripMenuItem.Text = "DÜZENLE";
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(149, 64);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(167, 22);
            this.txtTcKimlik.TabIndex = 1;
            this.txtTcKimlik.TextChanged += new System.EventHandler(this.txtTcKimlik_TextChanged);
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(149, 140);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(167, 22);
            this.txtMusteriSoyad.TabIndex = 2;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(149, 102);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(167, 22);
            this.txtMusteriAd.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(149, 182);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(167, 22);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtKayitTarihi
            // 
            this.txtKayitTarihi.Location = new System.Drawing.Point(149, 229);
            this.txtKayitTarihi.Name = "txtKayitTarihi";
            this.txtKayitTarihi.Size = new System.Drawing.Size(167, 22);
            this.txtKayitTarihi.TabIndex = 5;
            // 
            // cmbKurum
            // 
            this.cmbKurum.FormattingEnabled = true;
            this.cmbKurum.Location = new System.Drawing.Point(149, 275);
            this.cmbKurum.Name = "cmbKurum";
            this.cmbKurum.Size = new System.Drawing.Size(167, 24);
            this.cmbKurum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Müşteri Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Müşteri Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-112, -58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefon Numarası";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kayıt Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(15, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kurumu";
            // 
            // textstok_adı
            // 
            this.textstok_adı.FormattingEnabled = true;
            this.textstok_adı.Location = new System.Drawing.Point(657, 61);
            this.textstok_adı.Name = "textstok_adı";
            this.textstok_adı.Size = new System.Drawing.Size(121, 24);
            this.textstok_adı.TabIndex = 14;
            // 
            // txtStokAdedi
            // 
            this.txtStokAdedi.FormattingEnabled = true;
            this.txtStokAdedi.Location = new System.Drawing.Point(657, 118);
            this.txtStokAdedi.Name = "txtStokAdedi";
            this.txtStokAdedi.Size = new System.Drawing.Size(121, 24);
            this.txtStokAdedi.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(553, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "İlacın Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(553, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Stok Adedi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(553, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Adet";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(657, 169);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(121, 22);
            this.txtAdet.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(553, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fiyat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(553, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Tutar";
            // 
            // txtFiyat
            // 
            this.txtFiyat.AutoSize = true;
            this.txtFiyat.Location = new System.Drawing.Point(654, 229);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(54, 16);
            this.txtFiyat.TabIndex = 22;
            this.txtFiyat.Text = "_ _ _ _ _";
            // 
            // txtTutar
            // 
            this.txtTutar.AutoSize = true;
            this.txtTutar.Location = new System.Drawing.Point(654, 275);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(54, 16);
            this.txtTutar.TabIndex = 23;
            this.txtTutar.Text = "_ _ _ _ _";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KULLANICI_ADI,
            this.KULLANICI_SOYADI,
            this.KULLANICI_TELEFON,
            this.BAĞLI_OLDUĞU_KURUM,
            this.KAYIT_TARİHİ,
            this.İLACIN_ADI,
            this.STOK_ADEDİ,
            this.FİYAT,
            this.TUTAR});
            this.dataGridView1.Location = new System.Drawing.Point(15, 432);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 353);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // KULLANICI_ADI
            // 
            this.KULLANICI_ADI.HeaderText = "KULLANICI_ADI";
            this.KULLANICI_ADI.MinimumWidth = 6;
            this.KULLANICI_ADI.Name = "KULLANICI_ADI";
            // 
            // KULLANICI_SOYADI
            // 
            this.KULLANICI_SOYADI.HeaderText = "KULLANICI_SOYADI";
            this.KULLANICI_SOYADI.MinimumWidth = 6;
            this.KULLANICI_SOYADI.Name = "KULLANICI_SOYADI";
            // 
            // KULLANICI_TELEFON
            // 
            this.KULLANICI_TELEFON.HeaderText = "KULLANICI_TELEFON";
            this.KULLANICI_TELEFON.MinimumWidth = 6;
            this.KULLANICI_TELEFON.Name = "KULLANICI_TELEFON";
            // 
            // BAĞLI_OLDUĞU_KURUM
            // 
            this.BAĞLI_OLDUĞU_KURUM.HeaderText = "BAĞLI_OLDUĞU_KURUM";
            this.BAĞLI_OLDUĞU_KURUM.MinimumWidth = 6;
            this.BAĞLI_OLDUĞU_KURUM.Name = "BAĞLI_OLDUĞU_KURUM";
            // 
            // KAYIT_TARİHİ
            // 
            this.KAYIT_TARİHİ.HeaderText = "KAYIT_TARİHİ";
            this.KAYIT_TARİHİ.MinimumWidth = 6;
            this.KAYIT_TARİHİ.Name = "KAYIT_TARİHİ";
            // 
            // İLACIN_ADI
            // 
            this.İLACIN_ADI.HeaderText = "İLACIN_ADI";
            this.İLACIN_ADI.MinimumWidth = 6;
            this.İLACIN_ADI.Name = "İLACIN_ADI";
            // 
            // STOK_ADEDİ
            // 
            this.STOK_ADEDİ.HeaderText = "STOK_ADEDİ";
            this.STOK_ADEDİ.MinimumWidth = 6;
            this.STOK_ADEDİ.Name = "STOK_ADEDİ";
            // 
            // FİYAT
            // 
            this.FİYAT.HeaderText = "FİYAT";
            this.FİYAT.MinimumWidth = 6;
            this.FİYAT.Name = "FİYAT";
            // 
            // TUTAR
            // 
            this.TUTAR.HeaderText = "TUTAR";
            this.TUTAR.MinimumWidth = 6;
            this.TUTAR.Name = "TUTAR";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(556, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 77);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(691, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 73);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butonilaçsatıç_hastakontrol_Click
            // 
            this.butonilaçsatıç_hastakontrol_Click.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butonilaçsatıç_hastakontrol_Click.BackgroundImage")));
            this.butonilaçsatıç_hastakontrol_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butonilaçsatıç_hastakontrol_Click.Location = new System.Drawing.Point(345, 64);
            this.butonilaçsatıç_hastakontrol_Click.Name = "butonilaçsatıç_hastakontrol_Click";
            this.butonilaçsatıç_hastakontrol_Click.Size = new System.Drawing.Size(84, 78);
            this.butonilaçsatıç_hastakontrol_Click.TabIndex = 27;
            this.butonilaçsatıç_hastakontrol_Click.UseVisualStyleBackColor = true;
            this.butonilaçsatıç_hastakontrol_Click.Click += new System.EventHandler(this.butonilaçsatıç_hastakontrol_Click_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(345, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 78);
            this.button3.TabIndex = 28;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(13, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Alıcı Adı";
            // 
            // cmbIlacAdi
            // 
            this.cmbIlacAdi.FormattingEnabled = true;
            this.cmbIlacAdi.Location = new System.Drawing.Point(149, 337);
            this.cmbIlacAdi.Name = "cmbIlacAdi";
            this.cmbIlacAdi.Size = new System.Drawing.Size(167, 24);
            this.cmbIlacAdi.TabIndex = 31;
            // 
            // ÇALIŞAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 785);
            this.Controls.Add(this.cmbIlacAdi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butonilaçsatıç_hastakontrol_Click);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStokAdedi);
            this.Controls.Add(this.textstok_adı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKurum);
            this.Controls.Add(this.txtKayitTarihi);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ÇALIŞAN";
            this.Text = "ÇALIŞAN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOSYAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dÜZENLEToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtKayitTarihi;
        private System.Windows.Forms.ComboBox cmbKurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox textstok_adı;
        private System.Windows.Forms.ComboBox txtStokAdedi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtFiyat;
        private System.Windows.Forms.Label txtTutar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KULLANICI_ADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KULLANICI_SOYADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KULLANICI_TELEFON;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAĞLI_OLDUĞU_KURUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn KAYIT_TARİHİ;
        private System.Windows.Forms.DataGridViewTextBoxColumn İLACIN_ADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOK_ADEDİ;
        private System.Windows.Forms.DataGridViewTextBoxColumn FİYAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TUTAR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butonilaçsatıç_hastakontrol_Click;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbIlacAdi;
    }
}