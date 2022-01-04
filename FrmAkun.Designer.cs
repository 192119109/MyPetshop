namespace PetShop
{
    partial class FrmAkun
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.chkShowOldPass = new System.Windows.Forms.CheckBox();
            this.chkShowNewPass = new System.Windows.Forms.CheckBox();
            this.btnUbah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(208, 232);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(411, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(208, 280);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(411, 20);
            this.txtOldPass.TabIndex = 2;
            this.txtOldPass.TextChanged += new System.EventHandler(this.TxtOldPass_TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(208, 351);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(411, 20);
            this.txtNewPass.TabIndex = 3;
            // 
            // chkShowOldPass
            // 
            this.chkShowOldPass.AutoSize = true;
            this.chkShowOldPass.Location = new System.Drawing.Point(208, 306);
            this.chkShowOldPass.Name = "chkShowOldPass";
            this.chkShowOldPass.Size = new System.Drawing.Size(159, 17);
            this.chkShowOldPass.TabIndex = 4;
            this.chkShowOldPass.Text = "Tampilkan Kata Sandi Lama";
            this.chkShowOldPass.UseVisualStyleBackColor = true;
            this.chkShowOldPass.CheckedChanged += new System.EventHandler(this.ChkShowOldPass_CheckedChanged);
            // 
            // chkShowNewPass
            // 
            this.chkShowNewPass.AutoSize = true;
            this.chkShowNewPass.Location = new System.Drawing.Point(208, 377);
            this.chkShowNewPass.Name = "chkShowNewPass";
            this.chkShowNewPass.Size = new System.Drawing.Size(155, 17);
            this.chkShowNewPass.TabIndex = 5;
            this.chkShowNewPass.Text = "Tampilkan Kata Sandi Baru";
            this.chkShowNewPass.UseVisualStyleBackColor = true;
            this.chkShowNewPass.CheckedChanged += new System.EventHandler(this.ChkShowNewPass_CheckedChanged);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.Coral;
            this.btnUbah.Location = new System.Drawing.Point(262, 465);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(307, 41);
            this.btnUbah.TabIndex = 6;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ubah Informasi Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pengguna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kata Sandi Lama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kata Sandi Baru";
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(212, 423);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(407, 20);
            this.txtSecretKey.TabIndex = 11;
            this.txtSecretKey.TextChanged += new System.EventHandler(this.TxtSecretKey_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "SecretKeyLogger";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(304, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "(Apabila Lupa Kata Sandi Lama)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PetShop.Properties.Resources.kittyAccount;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(344, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAkun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(809, 518);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.chkShowNewPass);
            this.Controls.Add(this.chkShowOldPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmAkun";
            this.Text = "Akun";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAkun_FormClosed);
            this.Load += new System.EventHandler(this.FrmAkun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.CheckBox chkShowOldPass;
        private System.Windows.Forms.CheckBox chkShowNewPass;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}