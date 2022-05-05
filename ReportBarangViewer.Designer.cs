namespace PetShop
{
    partial class ReportBarangViewer
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
            this.rptBarangViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_petshopBarang = new PetShop.db_petshopBarang();
            this.Barang1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Barang1TableAdapter = new PetShop.db_petshopBarangTableAdapters.Barang1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barang1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptBarangViewer
            // 
            this.rptBarangViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsBarang";
            reportDataSource1.Value = this.Barang1BindingSource;
            this.rptBarangViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptBarangViewer.LocalReport.ReportEmbeddedResource = "PetShop.ReportBarang.rdlc";
            this.rptBarangViewer.Location = new System.Drawing.Point(0, 0);
            this.rptBarangViewer.Name = "rptBarangViewer";
            this.rptBarangViewer.ServerReport.BearerToken = null;
            this.rptBarangViewer.Size = new System.Drawing.Size(800, 450);
            this.rptBarangViewer.TabIndex = 0;
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
            // ReportBarangViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptBarangViewer);
            this.Name = "ReportBarangViewer";
            this.Text = "ReportBarangViewer";
            this.Load += new System.EventHandler(this.ReportBarangViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barang1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBarangViewer;
        private System.Windows.Forms.BindingSource Barang1BindingSource;
        private db_petshopBarang db_petshopBarang;
        private db_petshopBarangTableAdapters.Barang1TableAdapter Barang1TableAdapter;
    }
}