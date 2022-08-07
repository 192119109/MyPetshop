namespace PetShop
{
    partial class frmRptBarangTersedia
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
            this.rptBarangTersedia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_petshopBarang = new PetShop.db_petshopBarang();
            this.Barang1TableAdapter = new PetShop.db_petshopBarangTableAdapters.Barang1TableAdapter();
            this.barangTersediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTersediaTableAdapter = new PetShop.db_petshopBarangTableAdapters.BarangTersediaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangTersediaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptBarangTersedia
            // 
            this.rptBarangTersedia.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsBarang";
            reportDataSource1.Value = this.barangTersediaBindingSource;
            this.rptBarangTersedia.LocalReport.DataSources.Add(reportDataSource1);
            this.rptBarangTersedia.LocalReport.ReportEmbeddedResource = "PetShop.ReportBarang.rdlc";
            this.rptBarangTersedia.Location = new System.Drawing.Point(0, 0);
            this.rptBarangTersedia.Name = "rptBarangTersedia";
            this.rptBarangTersedia.ServerReport.BearerToken = null;
            this.rptBarangTersedia.Size = new System.Drawing.Size(800, 450);
            this.rptBarangTersedia.TabIndex = 0;
            // 
            // db_petshopBarang
            // 
            this.db_petshopBarang.DataSetName = "db_petshopBarang";
            this.db_petshopBarang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Barang1TableAdapter
            // 
            this.Barang1TableAdapter.ClearBeforeFill = true;
            // 
            // barangTersediaBindingSource
            // 
            this.barangTersediaBindingSource.DataMember = "BarangTersedia";
            this.barangTersediaBindingSource.DataSource = this.db_petshopBarang;
            // 
            // barangTersediaTableAdapter
            // 
            this.barangTersediaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptBarangTersedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptBarangTersedia);
            this.Name = "frmRptBarangTersedia";
            this.Text = "Laporan Barang Tersedia";
            this.Load += new System.EventHandler(this.FrmRptBarangTersedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangTersediaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBarangTersedia;
        private db_petshopBarang db_petshopBarang;
        private db_petshopBarangTableAdapters.Barang1TableAdapter Barang1TableAdapter;
        private System.Windows.Forms.BindingSource barangTersediaBindingSource;
        private db_petshopBarangTableAdapters.BarangTersediaTableAdapter barangTersediaTableAdapter;
    }
}