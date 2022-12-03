namespace PetShop
{
    partial class FrmPembelian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPembelian = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFilter2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFilter1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pembelian";
            // 
            // dgvPembelian
            // 
            this.dgvPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPembelian.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPembelian.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPembelian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPembelian.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPembelian.Location = new System.Drawing.Point(12, 139);
            this.dgvPembelian.MultiSelect = false;
            this.dgvPembelian.Name = "dgvPembelian";
            this.dgvPembelian.Size = new System.Drawing.Size(823, 543);
            this.dgvPembelian.TabIndex = 13;
            this.dgvPembelian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPembelian_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFilter);
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(841, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 91);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "By- Id Pembelian",
            "By- Id Supplier"});
            this.cbFilter.Location = new System.Drawing.Point(7, 52);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(484, 28);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.TxtCari_TextChanged);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(6, 19);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(485, 26);
            this.txtCari.TabIndex = 0;
            this.txtCari.TextChanged += new System.EventHandler(this.TxtCari_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTampil);
            this.groupBox2.Controls.Add(this.btnCetak);
            this.groupBox2.Controls.Add(this.btnTambah);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(848, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 118);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alat";
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.Color.Coral;
            this.btnTampil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampil.Image = global::PetShop.Properties.Resources.Square71x71Logo_scale_125;
            this.btnTampil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTampil.Location = new System.Drawing.Point(241, 25);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(243, 81);
            this.btnTampil.TabIndex = 17;
            this.btnTampil.Text = "Preview";
            this.btnTampil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTampil.UseVisualStyleBackColor = false;
            this.btnTampil.Click += new System.EventHandler(this.BtnTampil_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetak.Image = global::PetShop.Properties.Resources.edit_AeQ_icon;
            this.btnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(6, 68);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(229, 38);
            this.btnCetak.TabIndex = 16;
            this.btnCetak.Text = "Cetak Laporan";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.BtnCetak_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.Image = global::PetShop.Properties.Resources.add_Ypb_icon;
            this.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambah.Location = new System.Drawing.Point(6, 25);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(229, 37);
            this.btnTambah.TabIndex = 15;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDetail);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(847, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 249);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informasi";
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(7, 25);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.Size = new System.Drawing.Size(478, 218);
            this.dgvDetail.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dtpFilter2);
            this.groupBox4.Controls.Add(this.dtpFilter1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(847, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(491, 67);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "s/d";
            // 
            // dtpFilter2
            // 
            this.dtpFilter2.Location = new System.Drawing.Point(279, 25);
            this.dtpFilter2.Name = "dtpFilter2";
            this.dtpFilter2.Size = new System.Drawing.Size(200, 26);
            this.dtpFilter2.TabIndex = 1;
            this.dtpFilter2.ValueChanged += new System.EventHandler(this.DtpFilter1_ValueChanged);
            // 
            // dtpFilter1
            // 
            this.dtpFilter1.Location = new System.Drawing.Point(7, 26);
            this.dtpFilter1.Name = "dtpFilter1";
            this.dtpFilter1.Size = new System.Drawing.Size(200, 26);
            this.dtpFilter1.TabIndex = 0;
            this.dtpFilter1.ValueChanged += new System.EventHandler(this.DtpFilter1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PetShop.Properties.Resources.shopping_bag;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1350, 694);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPembelian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPembelian";
            this.Text = "Pembelian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPembelian_FormClosed);
            this.Load += new System.EventHandler(this.FrmPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPembelian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpFilter2;
        private System.Windows.Forms.DateTimePicker dtpFilter1;
        private System.Windows.Forms.Label label3;
    }
}