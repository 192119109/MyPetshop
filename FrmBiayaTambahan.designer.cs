﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCetak = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblJlhRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dgvHistoryBL = new System.Windows.Forms.DataGridView();
            this.nudBiaya = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtKet = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.cmbBln = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbBiayaLain = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBiaya)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox4.Controls.Add(this.btnCetak);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.nudBiaya);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtID);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtKet);
            this.groupBox4.Controls.Add(this.btnSimpan);
            this.groupBox4.Controls.Add(this.cmbBln);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.cmbBiayaLain);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(853, 414);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Image = global::PetShop.Properties.Resources.edit_AeQ_icon;
            this.btnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(13, 364);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(332, 38);
            this.btnCetak.TabIndex = 24;
            this.btnCetak.Text = "Cetak Laporan";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.BtnCetak_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblJlhRecord);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.dgvHistoryBL);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(363, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 395);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History";
            // 
            // lblJlhRecord
            // 
            this.lblJlhRecord.AutoSize = true;
            this.lblJlhRecord.Location = new System.Drawing.Point(449, 61);
            this.lblJlhRecord.Name = "lblJlhRecord";
            this.lblJlhRecord.Size = new System.Drawing.Size(19, 20);
            this.lblJlhRecord.TabIndex = 5;
            this.lblJlhRecord.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "s/d";
            // 
            // dtp2
            // 
            this.dtp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Location = new System.Drawing.Point(264, 25);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 22);
            this.dtp2.TabIndex = 2;
            this.dtp2.ValueChanged += new System.EventHandler(this.Dtp1_ValueChanged);
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Location = new System.Drawing.Point(19, 25);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 22);
            this.dtp1.TabIndex = 1;
            this.dtp1.ValueChanged += new System.EventHandler(this.Dtp1_ValueChanged);
            // 
            // dgvHistoryBL
            // 
            this.dgvHistoryBL.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHistoryBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistoryBL.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistoryBL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHistoryBL.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvHistoryBL.Location = new System.Drawing.Point(3, 91);
            this.dgvHistoryBL.Name = "dgvHistoryBL";
            this.dgvHistoryBL.Size = new System.Drawing.Size(481, 301);
            this.dgvHistoryBL.TabIndex = 0;
            // 
            // nudBiaya
            // 
            this.nudBiaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBiaya.Location = new System.Drawing.Point(145, 277);
            this.nudBiaya.Name = "nudBiaya";
            this.nudBiaya.Size = new System.Drawing.Size(200, 26);
            this.nudBiaya.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID :";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(145, 77);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(200, 26);
            this.txtID.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 198);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 26);
            this.label20.TabIndex = 19;
            this.label20.Text = "Keterangan :";
            // 
            // txtKet
            // 
            this.txtKet.BackColor = System.Drawing.SystemColors.Window;
            this.txtKet.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKet.Location = new System.Drawing.Point(145, 190);
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
            this.btnSimpan.Location = new System.Drawing.Point(145, 309);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(200, 37);
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // cmbBln
            // 
            this.cmbBln.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBln.FormattingEnabled = true;
            this.cmbBln.Location = new System.Drawing.Point(145, 149);
            this.cmbBln.Name = "cmbBln";
            this.cmbBln.Size = new System.Drawing.Size(200, 34);
            this.cmbBln.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(55, 277);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 26);
            this.label17.TabIndex = 15;
            this.label17.Text = "Biaya :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(52, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 26);
            this.label21.TabIndex = 14;
            this.label21.Text = "Bulan :";
            // 
            // cmbBiayaLain
            // 
            this.cmbBiayaLain.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBiayaLain.FormattingEnabled = true;
            this.cmbBiayaLain.Location = new System.Drawing.Point(145, 109);
            this.cmbBiayaLain.Name = "cmbBiayaLain";
            this.cmbBiayaLain.Size = new System.Drawing.Size(200, 34);
            this.cmbBiayaLain.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(62, 112);
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
            this.button1.Location = new System.Drawing.Point(136, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 40);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(179, 28);
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
            this.ClientSize = new System.Drawing.Size(853, 414);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmBiayaTambahan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biaya Tambahan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBiayaTambahan_FormClosed);
            this.Load += new System.EventHandler(this.FrmBiayaTambahan_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBiaya)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtKet;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ComboBox cmbBln;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbBiayaLain;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.NumericUpDown nudBiaya;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DataGridView dgvHistoryBL;
        private System.Windows.Forms.Label lblJlhRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCetak;
    }
}