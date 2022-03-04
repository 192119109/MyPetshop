namespace PetShop
{
    partial class FrmBackupData
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLastBackup = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, -2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(680, 92);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = "Backup and Restore Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Backup : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblLastBackup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO";
            // 
            // lblLastBackup
            // 
            this.lblLastBackup.AutoSize = true;
            this.lblLastBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastBackup.Location = new System.Drawing.Point(106, 22);
            this.lblLastBackup.Name = "lblLastBackup";
            this.lblLastBackup.Size = new System.Drawing.Size(17, 15);
            this.lblLastBackup.TabIndex = 5;
            this.lblLastBackup.Text = " - ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PetShop.Properties.Resources.data_recovery__1_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 88);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnRestore
            // 
            this.BtnRestore.BackColor = System.Drawing.Color.Gold;
            this.BtnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestore.Image = global::PetShop.Properties.Resources.restore__1_;
            this.BtnRestore.Location = new System.Drawing.Point(345, 127);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(322, 265);
            this.BtnRestore.TabIndex = 1;
            this.BtnRestore.Text = "Restore Database";
            this.BtnRestore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRestore.UseVisualStyleBackColor = false;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Image = global::PetShop.Properties.Resources.data_recovery__2_;
            this.btnBackup.Location = new System.Drawing.Point(12, 127);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(322, 265);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup Database";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path : ";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(64, 46);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(17, 15);
            this.lblPath.TabIndex = 7;
            this.lblPath.Text = " - ";
            // 
            // FrmBackupData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(679, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BtnRestore);
            this.Controls.Add(this.btnBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBackupData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBackupData_FormClosed);
            this.Load += new System.EventHandler(this.FrmBackupData_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button BtnRestore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLastBackup;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label label3;
    }
}