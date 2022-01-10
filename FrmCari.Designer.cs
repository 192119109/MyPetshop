namespace PetShop
{
    partial class FrmCari
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
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbSearchProduct = new System.Windows.Forms.GroupBox();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.gbSearchProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBarang
            // 
            this.dgvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarang.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBarang.Location = new System.Drawing.Point(12, 134);
            this.dgvBarang.MultiSelect = false;
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.Size = new System.Drawing.Size(842, 379);
            this.dgvBarang.TabIndex = 12;
            this.dgvBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBarang_CellClick);
            this.dgvBarang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBarang_CellDoubleClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Location = new System.Drawing.Point(141, 88);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 40);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Location = new System.Drawing.Point(12, 88);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(123, 40);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // gbSearchProduct
            // 
            this.gbSearchProduct.Controls.Add(this.cbSearchBy);
            this.gbSearchProduct.Controls.Add(this.btnSearch);
            this.gbSearchProduct.Controls.Add(this.txtSearch);
            this.gbSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchProduct.Location = new System.Drawing.Point(12, 12);
            this.gbSearchProduct.Name = "gbSearchProduct";
            this.gbSearchProduct.Size = new System.Drawing.Size(819, 70);
            this.gbSearchProduct.TabIndex = 16;
            this.gbSearchProduct.TabStop = false;
            this.gbSearchProduct.Text = "Cari Produk";
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "By ID Barang",
            "By Nama Barang"});
            this.cbSearchBy.Location = new System.Drawing.Point(590, 34);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(223, 26);
            this.cbSearchBy.TabIndex = 9;
            this.cbSearchBy.SelectedIndexChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::PetShop.Properties.Resources.magnifier;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PapayaWhip;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(3, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSearch.Location = new System.Drawing.Point(44, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(540, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // FrmCari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(866, 525);
            this.Controls.Add(this.gbSearchProduct);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cari Barang";
            this.Load += new System.EventHandler(this.FrmCari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.gbSearchProduct.ResumeLayout(false);
            this.gbSearchProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gbSearchProduct;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}