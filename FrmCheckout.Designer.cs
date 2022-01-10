namespace PetShop
{
    partial class FrmCheckout
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBayarCetak = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDibayarkan = new System.Windows.Forms.NumericUpDown();
            this.txtKembalian = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDibayarkan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rp. ";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(160, 52);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(569, 55);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBayarCetak
            // 
            this.btnBayarCetak.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBayarCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBayarCetak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBayarCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayarCetak.Location = new System.Drawing.Point(12, 314);
            this.btnBayarCetak.Name = "btnBayarCetak";
            this.btnBayarCetak.Size = new System.Drawing.Size(412, 57);
            this.btnBayarCetak.TabIndex = 1;
            this.btnBayarCetak.Text = "Bayar dan Cetak Struk";
            this.btnBayarCetak.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Uang yang dibayarkan : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kembalian : ";
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.Color.Orange;
            this.btnBayar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBayar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBayar.Location = new System.Drawing.Point(442, 314);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(320, 57);
            this.btnBayar.TabIndex = 2;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.BtnBayar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rp.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rp.";
            // 
            // nudDibayarkan
            // 
            this.nudDibayarkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDibayarkan.Location = new System.Drawing.Point(356, 199);
            this.nudDibayarkan.Name = "nudDibayarkan";
            this.nudDibayarkan.Size = new System.Drawing.Size(396, 31);
            this.nudDibayarkan.TabIndex = 2;
            this.nudDibayarkan.ValueChanged += new System.EventHandler(this.NudDibayarkan_ValueChanged);
            // 
            // txtKembalian
            // 
            this.txtKembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKembalian.Location = new System.Drawing.Point(356, 249);
            this.txtKembalian.Name = "txtKembalian";
            this.txtKembalian.ReadOnly = true;
            this.txtKembalian.Size = new System.Drawing.Size(396, 31);
            this.txtKembalian.TabIndex = 11;
            this.txtKembalian.Text = "0";
            // 
            // FrmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(774, 392);
            this.Controls.Add(this.txtKembalian);
            this.Controls.Add(this.nudDibayarkan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.btnBayarCetak);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bayar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCheckout_FormClosed);
            this.Load += new System.EventHandler(this.FrmCheckout_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDibayarkan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBayarCetak;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDibayarkan;
        private System.Windows.Forms.TextBox txtKembalian;
    }
}