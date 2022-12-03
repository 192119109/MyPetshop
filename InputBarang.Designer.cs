namespace PetShop
{
    partial class InputBarang
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtIdBrg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.nudHargaJual = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaJual)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PetShop.Properties.Resources.stock;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(-127, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "Input Barang";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nudHargaJual);
            this.groupBox1.Controls.Add(this.txtDeskripsi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnUbah);
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.Controls.Add(this.txtNamaBarang);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.txtIdBrg);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(621, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 411);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Barang";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(150, 194);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDeskripsi.Size = new System.Drawing.Size(266, 72);
            this.txtDeskripsi.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Deskripsi :";
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.Tomato;
            this.btnUbah.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUbah.Location = new System.Drawing.Point(164, 313);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(123, 40);
            this.btnUbah.TabIndex = 35;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHapus.Location = new System.Drawing.Point(293, 313);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(123, 40);
            this.btnHapus.TabIndex = 34;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSimpan.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSimpan.Location = new System.Drawing.Point(35, 361);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(381, 40);
            this.btnSimpan.TabIndex = 33;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTambah.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTambah.Location = new System.Drawing.Point(35, 313);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(123, 40);
            this.btnTambah.TabIndex = 32;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(150, 118);
            this.txtNamaBarang.Multiline = true;
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(265, 27);
            this.txtNamaBarang.TabIndex = 27;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(151, 72);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(265, 27);
            this.txtBarcode.TabIndex = 26;
            // 
            // txtIdBrg
            // 
            this.txtIdBrg.Location = new System.Drawing.Point(151, 32);
            this.txtIdBrg.Multiline = true;
            this.txtIdBrg.Name = "txtIdBrg";
            this.txtIdBrg.Size = new System.Drawing.Size(265, 27);
            this.txtIdBrg.TabIndex = 25;
            this.txtIdBrg.TextChanged += new System.EventHandler(this.TxtIdBrg_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(24, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Harga Jual :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(7, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nama Barang:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(41, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Barcode :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(87, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Id :";
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Location = new System.Drawing.Point(12, 125);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.Size = new System.Drawing.Size(603, 400);
            this.dgvBarang.TabIndex = 3;
            this.dgvBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBarang_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Location = new System.Drawing.Point(908, 68);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 40);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // nudHargaJual
            // 
            this.nudHargaJual.Location = new System.Drawing.Point(151, 159);
            this.nudHargaJual.Name = "nudHargaJual";
            this.nudHargaJual.Size = new System.Drawing.Size(266, 26);
            this.nudHargaJual.TabIndex = 39;
            // 
            // InputBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1071, 537);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "InputBarang";
            this.Text = "InputBarang";
            this.Load += new System.EventHandler(this.InputBarang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaJual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtIdBrg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudHargaJual;
    }
}