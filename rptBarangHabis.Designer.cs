namespace PetShop
{
    partial class rptBarangHabisPreview
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
            this.rptBarangHabis = new Microsoft.Reporting.WinForms.ReportViewer();
            this.barangHabisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_petshopBarang = new PetShop.db_petshopBarang();
            this.barangHabisTableAdapter = new PetShop.db_petshopBarangTableAdapters.BarangHabisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barangHabisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // rptBarangHabis
            // 
            this.rptBarangHabis.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsBarang";
            reportDataSource1.Value = this.barangHabisBindingSource;
            this.rptBarangHabis.LocalReport.DataSources.Add(reportDataSource1);
            this.rptBarangHabis.LocalReport.ReportEmbeddedResource = "PetShop.ReportBarang.rdlc";
            this.rptBarangHabis.Location = new System.Drawing.Point(0, 0);
            this.rptBarangHabis.Name = "rptBarangHabis";
           // this.rptBarangHabis.ServerReport.BearerToken = null;
            this.rptBarangHabis.Size = new System.Drawing.Size(800, 450);
            this.rptBarangHabis.TabIndex = 0;
            // 
            // barangHabisBindingSource
            // 
            this.barangHabisBindingSource.DataMember = "BarangHabis";
            this.barangHabisBindingSource.DataSource = this.db_petshopBarang;
            // 
            // db_petshopBarang
            // 
            this.db_petshopBarang.DataSetName = "db_petshopBarang";
            this.db_petshopBarang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangHabisTableAdapter
            // 
            this.barangHabisTableAdapter.ClearBeforeFill = true;
            // 
            // rptBarangHabisPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptBarangHabis);
            this.Name = "rptBarangHabisPreview";
            this.Text = "Laporan Barang Habis";
            this.Load += new System.EventHandler(this.RptBarangHabis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barangHabisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBarangHabis;
        private db_petshopBarang db_petshopBarang;
        private System.Windows.Forms.BindingSource barangHabisBindingSource;
        private db_petshopBarangTableAdapters.BarangHabisTableAdapter barangHabisTableAdapter;
    }
}