namespace PetShop
{
    partial class FrmPengeluaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPengeluaran));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnBiayaLain = new System.Windows.Forms.Button();
            this.btnPengurangan = new System.Windows.Forms.Button();
            this.btnPembelian = new System.Windows.Forms.Button();
            this.btnLBiayaLain = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.btnLBiayaLain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 88);
            this.panel1.TabIndex = 35;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(130, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(203, 29);
            this.label25.TabIndex = 36;
            this.label25.Text = "Laporan Pengeluaran";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(137, -211);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(203, 29);
            this.label23.TabIndex = 35;
            this.label23.Text = "Laporan Pengeluaran";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.Gold;
            this.btnSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Image = global::PetShop.Properties.Resources.pengeluaran_summary;
            this.btnSummary.Location = new System.Drawing.Point(12, 365);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(778, 76);
            this.btnSummary.TabIndex = 39;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = false;
            this.btnSummary.Click += new System.EventHandler(this.BtnSummary_Click);
            // 
            // btnBiayaLain
            // 
            this.btnBiayaLain.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBiayaLain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiayaLain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiayaLain.Image = global::PetShop.Properties.Resources.pengeluaran_biaya_lain;
            this.btnBiayaLain.Location = new System.Drawing.Point(534, 93);
            this.btnBiayaLain.Name = "btnBiayaLain";
            this.btnBiayaLain.Size = new System.Drawing.Size(256, 265);
            this.btnBiayaLain.TabIndex = 38;
            this.btnBiayaLain.Text = "Biaya Lain";
            this.btnBiayaLain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBiayaLain.UseVisualStyleBackColor = false;
            this.btnBiayaLain.Click += new System.EventHandler(this.BtnBiayaLain_Click);
            // 
            // btnPengurangan
            // 
            this.btnPengurangan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPengurangan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPengurangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengurangan.Image = global::PetShop.Properties.Resources.pengeluaran_pengurangan;
            this.btnPengurangan.Location = new System.Drawing.Point(274, 93);
            this.btnPengurangan.Name = "btnPengurangan";
            this.btnPengurangan.Size = new System.Drawing.Size(256, 265);
            this.btnPengurangan.TabIndex = 37;
            this.btnPengurangan.Text = "Pengurangan Barang";
            this.btnPengurangan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPengurangan.UseVisualStyleBackColor = false;
            this.btnPengurangan.Click += new System.EventHandler(this.BtnPengurangan_Click);
            // 
            // btnPembelian
            // 
            this.btnPembelian.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPembelian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPembelian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembelian.Image = global::PetShop.Properties.Resources.pengeluaran_pembelian;
            this.btnPembelian.Location = new System.Drawing.Point(12, 94);
            this.btnPembelian.Name = "btnPembelian";
            this.btnPembelian.Size = new System.Drawing.Size(256, 265);
            this.btnPembelian.TabIndex = 36;
            this.btnPembelian.Text = "Pembelian";
            this.btnPembelian.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPembelian.UseVisualStyleBackColor = false;
            this.btnPembelian.Click += new System.EventHandler(this.BtnPembelian_Click);
            // 
            // btnLBiayaLain
            // 
            this.btnLBiayaLain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLBiayaLain.BackgroundImage")));
            this.btnLBiayaLain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLBiayaLain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLBiayaLain.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLBiayaLain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PapayaWhip;
            this.btnLBiayaLain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btnLBiayaLain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLBiayaLain.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLBiayaLain.Location = new System.Drawing.Point(0, 0);
            this.btnLBiayaLain.Name = "btnLBiayaLain";
            this.btnLBiayaLain.Size = new System.Drawing.Size(101, 85);
            this.btnLBiayaLain.TabIndex = 34;
            this.btnLBiayaLain.UseVisualStyleBackColor = true;
            // 
            // FrmPengeluaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnBiayaLain);
            this.Controls.Add(this.btnPengurangan);
            this.Controls.Add(this.btnPembelian);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPengeluaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Pengeluaran";
            this.Load += new System.EventHandler(this.FrmPengeluaran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLBiayaLain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnPembelian;
        private System.Windows.Forms.Button btnPengurangan;
        private System.Windows.Forms.Button btnBiayaLain;
        private System.Windows.Forms.Button btnSummary;
    }
}