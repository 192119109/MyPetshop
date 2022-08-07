namespace PetShop
{
    partial class FrmReportBarangDiscontinued
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
            this.rptBarangDiscontinued = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_petshopBarang = new PetShop.db_petshopBarang();
            this.Barang1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Barang1TableAdapter = new PetShop.db_petshopBarangTableAdapters.Barang1TableAdapter();
            this.barangDiscontinuedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangDiscontinuedTableAdapter = new PetShop.db_petshopBarangTableAdapters.BarangDiscontinuedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barang1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangDiscontinuedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptBarangDiscontinued
            // 
            this.rptBarangDiscontinued.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsBarang";
            reportDataSource1.Value = this.barangDiscontinuedBindingSource;
            this.rptBarangDiscontinued.LocalReport.DataSources.Add(reportDataSource1);
            this.rptBarangDiscontinued.LocalReport.ReportEmbeddedResource = "PetShop.ReportBarang.rdlc";
            this.rptBarangDiscontinued.Location = new System.Drawing.Point(0, 0);
            this.rptBarangDiscontinued.Name = "rptBarangDiscontinued";
            this.rptBarangDiscontinued.ServerReport.BearerToken = null;
            this.rptBarangDiscontinued.Size = new System.Drawing.Size(800, 450);
            this.rptBarangDiscontinued.TabIndex = 0;
            // 
            // db_petshopBarang
            // 
            this.db_petshopBarang.DataSetName = "db_petshopBarang";
            this.db_petshopBarang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Barang1BindingSource
            // 
            this.Barang1BindingSource.DataMember = "Barang1";
            this.Barang1BindingSource.DataSource = this.db_petshopBarang;
            // 
            // Barang1TableAdapter
            // 
            this.Barang1TableAdapter.ClearBeforeFill = true;
            // 
            // barangDiscontinuedBindingSource
            // 
            this.barangDiscontinuedBindingSource.DataMember = "BarangDiscontinued";
            this.barangDiscontinuedBindingSource.DataSource = this.db_petshopBarang;
            // 
            // barangDiscontinuedTableAdapter
            // 
            this.barangDiscontinuedTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportBarangDiscontinued
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptBarangDiscontinued);
            this.Name = "FrmReportBarangDiscontinued";
            this.Text = "Laporan Barang Discontinued";
            this.Load += new System.EventHandler(this.FrmReportBarangDiscontinued_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barang1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangDiscontinuedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBarangDiscontinued;
        private System.Windows.Forms.BindingSource Barang1BindingSource;
        private db_petshopBarang db_petshopBarang;
        private db_petshopBarangTableAdapters.Barang1TableAdapter Barang1TableAdapter;
        private System.Windows.Forms.BindingSource barangDiscontinuedBindingSource;
        private db_petshopBarangTableAdapters.BarangDiscontinuedTableAdapter barangDiscontinuedTableAdapter;
    }
}