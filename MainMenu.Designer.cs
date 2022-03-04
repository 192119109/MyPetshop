namespace PetShop
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lblTutupApps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBantuan = new System.Windows.Forms.LinkLabel();
            this.btnManageData = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnBiayaTambahan = new System.Windows.Forms.Button();
            this.btnPersediaan = new System.Windows.Forms.Button();
            this.btnPenjualan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTutupApps
            // 
            this.lblTutupApps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTutupApps.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutupApps.Location = new System.Drawing.Point(1225, 42);
            this.lblTutupApps.Name = "lblTutupApps";
            this.lblTutupApps.Size = new System.Drawing.Size(113, 55);
            this.lblTutupApps.TabIndex = 0;
            this.lblTutupApps.Text = "Tutup";
            this.lblTutupApps.Click += new System.EventHandler(this.LblTutupApps_Click);
            this.lblTutupApps.MouseEnter += new System.EventHandler(this.LblTutupApps_MouseEnter);
            this.lblTutupApps.MouseLeave += new System.EventHandler(this.LblTutupApps_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "MY PETSHOP";
            // 
            // lblBantuan
            // 
            this.lblBantuan.AutoSize = true;
            this.lblBantuan.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBantuan.LinkColor = System.Drawing.Color.Black;
            this.lblBantuan.Location = new System.Drawing.Point(67, 711);
            this.lblBantuan.Name = "lblBantuan";
            this.lblBantuan.Size = new System.Drawing.Size(96, 28);
            this.lblBantuan.TabIndex = 8;
            this.lblBantuan.TabStop = true;
            this.lblBantuan.Text = "Bantuan";
            this.lblBantuan.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lblBantuan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblBantuan_LinkClicked);
            // 
            // btnManageData
            // 
            this.btnManageData.BackgroundImage = global::PetShop.Properties.Resources.backup_file;
            this.btnManageData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageData.Location = new System.Drawing.Point(442, 411);
            this.btnManageData.Name = "btnManageData";
            this.btnManageData.Size = new System.Drawing.Size(208, 170);
            this.btnManageData.TabIndex = 10;
            this.btnManageData.UseVisualStyleBackColor = true;
            this.btnManageData.Click += new System.EventHandler(this.BtnManageData_Click);
            this.btnManageData.MouseEnter += new System.EventHandler(this.BtnManageData_MouseEnter);
            this.btnManageData.MouseLeave += new System.EventHandler(this.BtnManageData_MouseLeave);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackgroundImage = global::PetShop.Properties.Resources.supplier;
            this.btnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.Location = new System.Drawing.Point(207, 411);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(208, 170);
            this.btnSupplier.TabIndex = 9;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.BtnSupplier_Click);
            this.btnSupplier.MouseEnter += new System.EventHandler(this.BtnSupplier_MouseEnter);
            this.btnSupplier.MouseLeave += new System.EventHandler(this.BtnSupplier_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1068, 504);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 252);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnAccount
            // 
            this.btnAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.BackgroundImage")));
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.Location = new System.Drawing.Point(680, 411);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(208, 170);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            this.btnAccount.MouseEnter += new System.EventHandler(this.BtnAccount_MouseEnter);
            this.btnAccount.MouseLeave += new System.EventHandler(this.BtnAccount_MouseLeave);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLaporan.BackgroundImage")));
            this.btnLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaporan.Location = new System.Drawing.Point(917, 184);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(208, 170);
            this.btnLaporan.TabIndex = 4;
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.BtnLaporan_Click);
            this.btnLaporan.MouseEnter += new System.EventHandler(this.BtnLaporan_MouseEnter);
            this.btnLaporan.MouseLeave += new System.EventHandler(this.BtnLaporan_MouseLeave);
            // 
            // btnBiayaTambahan
            // 
            this.btnBiayaTambahan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBiayaTambahan.BackgroundImage")));
            this.btnBiayaTambahan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBiayaTambahan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiayaTambahan.Location = new System.Drawing.Point(680, 184);
            this.btnBiayaTambahan.Name = "btnBiayaTambahan";
            this.btnBiayaTambahan.Size = new System.Drawing.Size(208, 170);
            this.btnBiayaTambahan.TabIndex = 3;
            this.btnBiayaTambahan.UseVisualStyleBackColor = true;
            this.btnBiayaTambahan.MouseEnter += new System.EventHandler(this.BtnBiayaTambahan_MouseEnter);
            this.btnBiayaTambahan.MouseLeave += new System.EventHandler(this.BtnBiayaTambahan_MouseLeave);
            // 
            // btnPersediaan
            // 
            this.btnPersediaan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersediaan.BackgroundImage")));
            this.btnPersediaan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPersediaan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersediaan.Location = new System.Drawing.Point(442, 184);
            this.btnPersediaan.Name = "btnPersediaan";
            this.btnPersediaan.Size = new System.Drawing.Size(208, 170);
            this.btnPersediaan.TabIndex = 2;
            this.btnPersediaan.UseVisualStyleBackColor = true;
            this.btnPersediaan.Click += new System.EventHandler(this.BtnPersediaan_Click);
            this.btnPersediaan.MouseEnter += new System.EventHandler(this.BtnPersediaan_MouseEnter);
            this.btnPersediaan.MouseLeave += new System.EventHandler(this.BtnPersediaan_MouseLeave);
            // 
            // btnPenjualan
            // 
            this.btnPenjualan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPenjualan.BackgroundImage")));
            this.btnPenjualan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPenjualan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPenjualan.Location = new System.Drawing.Point(207, 184);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Size = new System.Drawing.Size(208, 170);
            this.btnPenjualan.TabIndex = 1;
            this.btnPenjualan.UseVisualStyleBackColor = true;
            this.btnPenjualan.Click += new System.EventHandler(this.BtnPenjualan_Click);
            this.btnPenjualan.MouseEnter += new System.EventHandler(this.BtnPenjualan_MouseEnter);
            this.btnPenjualan.MouseLeave += new System.EventHandler(this.BtnPenjualan_MouseLeave);
            // 
            // FrmMenu
            // 
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnManageData);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.lblBantuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnBiayaTambahan);
            this.Controls.Add(this.btnPersediaan);
            this.Controls.Add(this.btnPenjualan);
            this.Controls.Add(this.lblTutupApps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutup;
        private System.Windows.Forms.Label lblTutupApps;
        private System.Windows.Forms.Button btnPenjualan;
        private System.Windows.Forms.Button btnPersediaan;
        private System.Windows.Forms.Button btnBiayaTambahan;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblBantuan;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnManageData;
    }
}

