namespace PetShop
{
    partial class ReportPenguranganBarangPreview
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptPenguranganBarang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_petshopPenguranganStock = new PetShop.db_petshopPenguranganStock();
            this.Pengurangan_StockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pengurangan_StockTableAdapter = new PetShop.db_petshopPenguranganStockTableAdapters.Pengurangan_StockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopPenguranganStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pengurangan_StockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptPenguranganBarang
            // 
            this.rptPenguranganBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Pengurangan_Stock";
            reportDataSource1.Value = this.Pengurangan_StockBindingSource;
            this.rptPenguranganBarang.LocalReport.DataSources.Add(reportDataSource1);
            this.rptPenguranganBarang.LocalReport.ReportEmbeddedResource = "PetShop.ReportPenguranganBarang.rdlc";
            this.rptPenguranganBarang.Location = new System.Drawing.Point(0, 0);
            this.rptPenguranganBarang.Name = "rptPenguranganBarang";
            this.rptPenguranganBarang.ServerReport.BearerToken = null;
            this.rptPenguranganBarang.Size = new System.Drawing.Size(800, 450);
            this.rptPenguranganBarang.TabIndex = 0;
            // 
            // db_petshopPenguranganStock
            // 
            this.db_petshopPenguranganStock.DataSetName = "db_petshopPenguranganStock";
            this.db_petshopPenguranganStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pengurangan_StockBindingSource
            // 
            this.Pengurangan_StockBindingSource.DataMember = "Pengurangan_Stock";
            this.Pengurangan_StockBindingSource.DataSource = this.db_petshopPenguranganStock;
            // 
            // Pengurangan_StockTableAdapter
            // 
            this.Pengurangan_StockTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPenguranganBarangPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptPenguranganBarang);
            this.Name = "ReportPenguranganBarangPreview";
            this.Text = "Laporan Pengurangan Barang";
            this.Load += new System.EventHandler(this.ReportPenguranganBarangPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopPenguranganStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pengurangan_StockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptPenguranganBarang;
        private System.Windows.Forms.BindingSource Pengurangan_StockBindingSource;
        private db_petshopPenguranganStock db_petshopPenguranganStock;
        private db_petshopPenguranganStockTableAdapters.Pengurangan_StockTableAdapter Pengurangan_StockTableAdapter;
    }
}