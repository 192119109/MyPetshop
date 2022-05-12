
namespace PetShop
{
    partial class FrmBiayaTambahan
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtKet = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtBiaya = new System.Windows.Forms.TextBox();
            this.cmbBln = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbBiayaLain = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtKet);
            this.groupBox4.Controls.Add(this.btnSimpan);
            this.groupBox4.Controls.Add(this.txtBiaya);
            this.groupBox4.Controls.Add(this.cmbBln);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.cmbBiayaLain);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(10, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 315);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(4, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 26);
            this.label20.TabIndex = 19;
            this.label20.Text = "Keterangan :";
            // 
            // txtKet
            // 
            this.txtKet.BackColor = System.Drawing.SystemColors.Window;
            this.txtKet.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKet.Location = new System.Drawing.Point(141, 145);
            this.txtKet.Multiline = true;
            this.txtKet.Name = "txtKet";
            this.txtKet.Size = new System.Drawing.Size(200, 81);
            this.txtKet.TabIndex = 18;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimpan.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSimpan.Location = new System.Drawing.Point(141, 264);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(108, 47);
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Text = "OK";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtBiaya
            // 
            this.txtBiaya.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiaya.Location = new System.Drawing.Point(141, 232);
            this.txtBiaya.Multiline = true;
            this.txtBiaya.Name = "txtBiaya";
            this.txtBiaya.Size = new System.Drawing.Size(200, 26);
            this.txtBiaya.TabIndex = 17;
            // 
            // cmbBln
            // 
            this.cmbBln.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBln.FormattingEnabled = true;
            this.cmbBln.Location = new System.Drawing.Point(141, 104);
            this.cmbBln.Name = "cmbBln";
            this.cmbBln.Size = new System.Drawing.Size(200, 34);
            this.cmbBln.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(51, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 26);
            this.label17.TabIndex = 15;
            this.label17.Text = "Biaya :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(48, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 26);
            this.label21.TabIndex = 14;
            this.label21.Text = "Bulan :";
            // 
            // cmbBiayaLain
            // 
            this.cmbBiayaLain.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBiayaLain.FormattingEnabled = true;
            this.cmbBiayaLain.Location = new System.Drawing.Point(141, 64);
            this.cmbBiayaLain.Name = "cmbBiayaLain";
            this.cmbBiayaLain.Size = new System.Drawing.Size(200, 34);
            this.cmbBiayaLain.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(58, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 26);
            this.label16.TabIndex = 11;
            this.label16.Text = "Pilih :";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PetShop.Properties.Resources.cashless_payment;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(139, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 40);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(182, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 26);
            this.label18.TabIndex = 2;
            this.label18.Text = "Biaya Lainnya";
            // 
            // FrmBiayaTambahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(384, 335);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmBiayaTambahan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biaya Tambahan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBiayaTambahan_FormClosed);
            this.Load += new System.EventHandler(this.FrmBiayaTambahan_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtKet;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtBiaya;
        private System.Windows.Forms.ComboBox cmbBln;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbBiayaLain;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
    }
}