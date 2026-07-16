namespace EczaneOtomasyonu1
{
    partial class MÜŞTERİ_BİLGİLERİ
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOSYAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KULLANICI_ADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KULLANICI_SOYADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KULLANICI_TELEFON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KULANICI_ADRESİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAĞLI_OLDUĞU_KURUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KAYIT_TARİHİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOSYAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dOSYAToolStripMenuItem
            // 
            this.dOSYAToolStripMenuItem.Name = "dOSYAToolStripMenuItem";
            this.dOSYAToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.dOSYAToolStripMenuItem.Text = "DOSYA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KULLANICI_ADI,
            this.KULLANICI_SOYADI,
            this.KULLANICI_TELEFON,
            this.KULANICI_ADRESİ,
            this.BAĞLI_OLDUĞU_KURUM,
            this.KAYIT_TARİHİ});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 422);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // KULLANICI_ADI
            // 
            this.KULLANICI_ADI.HeaderText = "KULLANICI_ADI";
            this.KULLANICI_ADI.MinimumWidth = 6;
            this.KULLANICI_ADI.Name = "KULLANICI_ADI";
            this.KULLANICI_ADI.Width = 125;
            // 
            // KULLANICI_SOYADI
            // 
            this.KULLANICI_SOYADI.HeaderText = "KULLANICI_SOYADI";
            this.KULLANICI_SOYADI.MinimumWidth = 6;
            this.KULLANICI_SOYADI.Name = "KULLANICI_SOYADI";
            this.KULLANICI_SOYADI.Width = 125;
            // 
            // KULLANICI_TELEFON
            // 
            this.KULLANICI_TELEFON.HeaderText = "KULLANICI_TELEFON";
            this.KULLANICI_TELEFON.MinimumWidth = 6;
            this.KULLANICI_TELEFON.Name = "KULLANICI_TELEFON";
            this.KULLANICI_TELEFON.Width = 125;
            // 
            // KULANICI_ADRESİ
            // 
            this.KULANICI_ADRESİ.HeaderText = "KULLANICI_ADRESİ";
            this.KULANICI_ADRESİ.MinimumWidth = 6;
            this.KULANICI_ADRESİ.Name = "KULANICI_ADRESİ";
            this.KULANICI_ADRESİ.Width = 125;
            // 
            // BAĞLI_OLDUĞU_KURUM
            // 
            this.BAĞLI_OLDUĞU_KURUM.HeaderText = "BAĞLI_OLDUĞU_KURUM";
            this.BAĞLI_OLDUĞU_KURUM.MinimumWidth = 6;
            this.BAĞLI_OLDUĞU_KURUM.Name = "BAĞLI_OLDUĞU_KURUM";
            this.BAĞLI_OLDUĞU_KURUM.Width = 125;
            // 
            // KAYIT_TARİHİ
            // 
            this.KAYIT_TARİHİ.HeaderText = "TC_KİMLİK_NO";
            this.KAYIT_TARİHİ.MinimumWidth = 6;
            this.KAYIT_TARİHİ.Name = "KAYIT_TARİHİ";
            this.KAYIT_TARİHİ.Width = 125;
            // 
            // MÜŞTERİ_BİLGİLERİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MÜŞTERİ_BİLGİLERİ";
            this.Text = "MÜŞTERİ_BİLGİLERİ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOSYAToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KULLANICI_ADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KULLANICI_SOYADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KULLANICI_TELEFON;
        private System.Windows.Forms.DataGridViewTextBoxColumn KULANICI_ADRESİ;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAĞLI_OLDUĞU_KURUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn KAYIT_TARİHİ;
    }
}