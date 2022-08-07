namespace PetShop
{
    partial class FrmLaporanBarang
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
            this.btnAllStock = new System.Windows.Forms.Button();
            this.btnStockHabis = new System.Windows.Forms.Button();
            this.btnStockDiscontinued = new System.Windows.Forms.Button();
            this.btnStockTersedia = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAllStock
            // 
            this.btnAllStock.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAllStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStock.Location = new System.Drawing.Point(14, 98);
            this.btnAllStock.Name = "btnAllStock";
            this.btnAllStock.Size = new System.Drawing.Size(311, 111);
            this.btnAllStock.TabIndex = 0;
            this.btnAllStock.Text = "All Stock";
            this.btnAllStock.UseVisualStyleBackColor = false;
            this.btnAllStock.Click += new System.EventHandler(this.BtnAllStock_Click);
            // 
            // btnStockHabis
            // 
            this.btnStockHabis.BackColor = System.Drawing.Color.Orange;
            this.btnStockHabis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockHabis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockHabis.Location = new System.Drawing.Point(342, 98);
            this.btnStockHabis.Name = "btnStockHabis";
            this.btnStockHabis.Size = new System.Drawing.Size(311, 111);
            this.btnStockHabis.TabIndex = 1;
            this.btnStockHabis.Text = "Stock Habis";
            this.btnStockHabis.UseVisualStyleBackColor = false;
            this.btnStockHabis.Click += new System.EventHandler(this.BtnStockHabis_Click);
            // 
            // btnStockDiscontinued
            // 
            this.btnStockDiscontinued.BackColor = System.Drawing.Color.IndianRed;
            this.btnStockDiscontinued.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockDiscontinued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockDiscontinued.Location = new System.Drawing.Point(342, 215);
            this.btnStockDiscontinued.Name = "btnStockDiscontinued";
            this.btnStockDiscontinued.Size = new System.Drawing.Size(311, 111);
            this.btnStockDiscontinued.TabIndex = 2;
            this.btnStockDiscontinued.Text = "Stock Discontinued";
            this.btnStockDiscontinued.UseVisualStyleBackColor = false;
            // 
            // btnStockTersedia
            // 
            this.btnStockTersedia.BackColor = System.Drawing.Color.CadetBlue;
            this.btnStockTersedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockTersedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockTersedia.Location = new System.Drawing.Point(14, 215);
            this.btnStockTersedia.Name = "btnStockTersedia";
            this.btnStockTersedia.Size = new System.Drawing.Size(311, 111);
            this.btnStockTersedia.TabIndex = 3;
            this.btnStockTersedia.Text = "Stock Tersedia";
            this.btnStockTersedia.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::PetShop.Properties.Resources.report1;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PapayaWhip;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(188, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 60);
            this.button5.TabIndex = 26;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Minion Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 44);
            this.label7.TabIndex = 27;
            this.label7.Text = "Laporan Barang";
            // 
            // FrmLaporanBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(665, 343);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnStockTersedia);
            this.Controls.Add(this.btnStockDiscontinued);
            this.Controls.Add(this.btnStockHabis);
            this.Controls.Add(this.btnAllStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLaporanBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Barang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllStock;
        private System.Windows.Forms.Button btnStockHabis;
        private System.Windows.Forms.Button btnStockDiscontinued;
        private System.Windows.Forms.Button btnStockTersedia;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
    }
}