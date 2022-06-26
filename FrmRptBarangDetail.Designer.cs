namespace PetShop
{
    partial class FrmRptBarangDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLapReadyStock = new System.Windows.Forms.Button();
            this.btnLapBarangKosong = new System.Windows.Forms.Button();
            this.btnLapPengurangan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 84);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(161, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "More Detail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PetShop.Properties.Resources.more;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLapReadyStock
            // 
            this.btnLapReadyStock.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLapReadyStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapReadyStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapReadyStock.Image = global::PetShop.Properties.Resources.ReadyStock;
            this.btnLapReadyStock.Location = new System.Drawing.Point(0, 87);
            this.btnLapReadyStock.Name = "btnLapReadyStock";
            this.btnLapReadyStock.Size = new System.Drawing.Size(344, 126);
            this.btnLapReadyStock.TabIndex = 5;
            this.btnLapReadyStock.Text = "Laporan Barang Tersedia";
            this.btnLapReadyStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLapReadyStock.UseVisualStyleBackColor = false;
            this.btnLapReadyStock.Click += new System.EventHandler(this.BtnLapReadyStock_Click);
            // 
            // btnLapBarangKosong
            // 
            this.btnLapBarangKosong.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLapBarangKosong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapBarangKosong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapBarangKosong.Image = global::PetShop.Properties.Resources.Square44x44Logo_targetsize_80;
            this.btnLapBarangKosong.Location = new System.Drawing.Point(0, 210);
            this.btnLapBarangKosong.Name = "btnLapBarangKosong";
            this.btnLapBarangKosong.Size = new System.Drawing.Size(344, 126);
            this.btnLapBarangKosong.TabIndex = 4;
            this.btnLapBarangKosong.Text = "Laporan Barang Habis";
            this.btnLapBarangKosong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLapBarangKosong.UseVisualStyleBackColor = false;
            // 
            // btnLapPengurangan
            // 
            this.btnLapPengurangan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLapPengurangan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapPengurangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPengurangan.Image = global::PetShop.Properties.Resources.PenguranganStock;
            this.btnLapPengurangan.Location = new System.Drawing.Point(0, 329);
            this.btnLapPengurangan.Name = "btnLapPengurangan";
            this.btnLapPengurangan.Size = new System.Drawing.Size(344, 126);
            this.btnLapPengurangan.TabIndex = 2;
            this.btnLapPengurangan.Text = "Laporan Pengurangan Stock";
            this.btnLapPengurangan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLapPengurangan.UseVisualStyleBackColor = false;
            // 
            // FrmRptBarangDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(344, 454);
            this.Controls.Add(this.btnLapReadyStock);
            this.Controls.Add(this.btnLapBarangKosong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLapPengurangan);
            this.Name = "FrmRptBarangDetail";
            this.Text = "Laporan Barang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLapPengurangan;
        private System.Windows.Forms.Button btnLapBarangKosong;
        private System.Windows.Forms.Button btnLapReadyStock;
    }
}