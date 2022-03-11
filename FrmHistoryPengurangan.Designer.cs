namespace PetShop
{
    partial class FrmHistoryPengurangan
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
            this.gbSearchProduct = new System.Windows.Forms.GroupBox();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvHistoryPengurangan = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbSearchProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryPengurangan)).BeginInit();
            this.SuspendLayout();
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
            this.gbSearchProduct.TabIndex = 17;
            this.gbSearchProduct.TabStop = false;
            this.gbSearchProduct.Text = "Cari";
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
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSearch.Location = new System.Drawing.Point(44, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(540, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvHistoryPengurangan
            // 
            this.dgvHistoryPengurangan.AllowUserToAddRows = false;
            this.dgvHistoryPengurangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryPengurangan.Location = new System.Drawing.Point(15, 88);
            this.dgvHistoryPengurangan.Name = "dgvHistoryPengurangan";
            this.dgvHistoryPengurangan.ReadOnly = true;
            this.dgvHistoryPengurangan.Size = new System.Drawing.Size(816, 404);
            this.dgvHistoryPengurangan.TabIndex = 18;
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
            // FrmHistoryPengurangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(839, 504);
            this.Controls.Add(this.dgvHistoryPengurangan);
            this.Controls.Add(this.gbSearchProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHistoryPengurangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History Pengurangan";
            this.Load += new System.EventHandler(this.FrmHistoryPengurangan_Load);
            this.gbSearchProduct.ResumeLayout(false);
            this.gbSearchProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryPengurangan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchProduct;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvHistoryPengurangan;
    }
}