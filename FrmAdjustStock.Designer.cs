namespace PetShop
{
    partial class FrmAdjustStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPembelian = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdjust = new System.Windows.Forms.Button();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.lblQtyAkhir = new System.Windows.Forms.Label();
            this.lblStockAwal = new System.Windows.Forms.Label();
            this.nudAjdust = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdjust = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCariBarang = new System.Windows.Forms.TextBox();
            this.txtCariPembelian = new System.Windows.Forms.TextBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAjdust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 112);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pengurangan Stock";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBarang);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 506);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barang";
            // 
            // dgvBarang
            // 
            this.dgvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBarang.Location = new System.Drawing.Point(3, 16);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.Size = new System.Drawing.Size(364, 487);
            this.dgvBarang.TabIndex = 0;
            this.dgvBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBarang_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPembelian);
            this.groupBox2.Location = new System.Drawing.Point(416, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 506);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pembelian";
            // 
            // dgvPembelian
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPembelian.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPembelian.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPembelian.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPembelian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPembelian.Location = new System.Drawing.Point(3, 16);
            this.dgvPembelian.Name = "dgvPembelian";
            this.dgvPembelian.Size = new System.Drawing.Size(635, 487);
            this.dgvPembelian.TabIndex = 0;
            this.dgvPembelian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPembelian_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = ">";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnAdjust);
            this.groupBox3.Controls.Add(this.txtDeskripsi);
            this.groupBox3.Controls.Add(this.lblQtyAkhir);
            this.groupBox3.Controls.Add(this.lblStockAwal);
            this.groupBox3.Controls.Add(this.nudAjdust);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblAdjust);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1063, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 503);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(8, 462);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(290, 35);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnAdjust
            // 
            this.btnAdjust.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdjust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjust.Location = new System.Drawing.Point(8, 421);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(290, 35);
            this.btnAdjust.TabIndex = 18;
            this.btnAdjust.Text = "Adjust";
            this.btnAdjust.UseVisualStyleBackColor = false;
            this.btnAdjust.Click += new System.EventHandler(this.BtnAdjust_Click);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(81, 176);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDeskripsi.Size = new System.Drawing.Size(214, 221);
            this.txtDeskripsi.TabIndex = 17;
            // 
            // lblQtyAkhir
            // 
            this.lblQtyAkhir.AutoSize = true;
            this.lblQtyAkhir.Location = new System.Drawing.Point(96, 83);
            this.lblQtyAkhir.Name = "lblQtyAkhir";
            this.lblQtyAkhir.Size = new System.Drawing.Size(16, 18);
            this.lblQtyAkhir.TabIndex = 16;
            this.lblQtyAkhir.Text = "0";
            // 
            // lblStockAwal
            // 
            this.lblStockAwal.AutoSize = true;
            this.lblStockAwal.Location = new System.Drawing.Point(95, 42);
            this.lblStockAwal.Name = "lblStockAwal";
            this.lblStockAwal.Size = new System.Drawing.Size(16, 18);
            this.lblStockAwal.TabIndex = 15;
            this.lblStockAwal.Text = "0";
            // 
            // nudAjdust
            // 
            this.nudAjdust.Location = new System.Drawing.Point(98, 132);
            this.nudAjdust.Name = "nudAjdust";
            this.nudAjdust.Size = new System.Drawing.Size(177, 24);
            this.nudAjdust.TabIndex = 14;
            this.nudAjdust.ValueChanged += new System.EventHandler(this.NudAjdust_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Deskripsi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Qty Akhir : ";
            // 
            // lblAdjust
            // 
            this.lblAdjust.AutoSize = true;
            this.lblAdjust.Location = new System.Drawing.Point(5, 132);
            this.lblAdjust.Name = "lblAdjust";
            this.lblAdjust.Size = new System.Drawing.Size(87, 18);
            this.lblAdjust.TabIndex = 11;
            this.lblAdjust.Text = "Qty Adjust : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Qty Awal : ";
            // 
            // txtCariBarang
            // 
            this.txtCariBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariBarang.ForeColor = System.Drawing.Color.Black;
            this.txtCariBarang.Location = new System.Drawing.Point(15, 145);
            this.txtCariBarang.Name = "txtCariBarang";
            this.txtCariBarang.Size = new System.Drawing.Size(367, 26);
            this.txtCariBarang.TabIndex = 6;
            this.txtCariBarang.TextChanged += new System.EventHandler(this.TxtCariBarang_TextChanged);
            this.txtCariBarang.Enter += new System.EventHandler(this.TxtCariBarang_Enter);
            this.txtCariBarang.Leave += new System.EventHandler(this.TxtCariBarang_Leave);
            // 
            // txtCariPembelian
            // 
            this.txtCariPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariPembelian.ForeColor = System.Drawing.Color.Black;
            this.txtCariPembelian.Location = new System.Drawing.Point(416, 145);
            this.txtCariPembelian.Name = "txtCariPembelian";
            this.txtCariPembelian.Size = new System.Drawing.Size(638, 26);
            this.txtCariPembelian.TabIndex = 7;
            this.txtCariPembelian.TextChanged += new System.EventHandler(this.TxtCariPembelian_TextChanged);
            this.txtCariPembelian.Enter += new System.EventHandler(this.TxtCariPembelian_Enter);
            this.txtCariPembelian.Leave += new System.EventHandler(this.TxtCariPembelian_Leave);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.BurlyWood;
            this.btnHistory.BackgroundImage = global::PetShop.Properties.Resources.history;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.btnHistory.Location = new System.Drawing.Point(1265, 19);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(73, 74);
            this.btnHistory.TabIndex = 44;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PetShop.Properties.Resources.stock1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAdjustStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1367, 729);
            this.Controls.Add(this.txtCariPembelian);
            this.Controls.Add(this.txtCariBarang);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAdjustStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengurangan Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdjustStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAjdust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPembelian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdjust;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label lblQtyAkhir;
        private System.Windows.Forms.Label lblStockAwal;
        private System.Windows.Forms.NumericUpDown nudAjdust;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdjust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCariBarang;
        private System.Windows.Forms.TextBox txtCariPembelian;
        private System.Windows.Forms.Button btnHistory;
    }
}