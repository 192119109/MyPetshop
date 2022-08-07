namespace PetShop
{
    partial class rptBarangTersediaPreview
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.db_petshopBarang = new PetShop.db_petshopBarang();
            this.rptBarangTersedia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.barangTersediaTableAdapter1 = new PetShop.db_petshopBarangTableAdapters.BarangTersediaTableAdapter();
            this.barangTersediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangTersediaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // db_petshopBarang
            // 
            this.db_petshopBarang.DataSetName = "db_petshopBarang";
            this.db_petshopBarang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptBarangTersedia
            // 
            this.rptBarangTersedia.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsBarang";
            reportDataSource2.Value = this.barangTersediaBindingSource;
            this.rptBarangTersedia.LocalReport.DataSources.Add(reportDataSource2);
            this.rptBarangTersedia.LocalReport.ReportEmbeddedResource = "PetShop.ReportBarang.rdlc";
            this.rptBarangTersedia.Location = new System.Drawing.Point(0, 0);
            this.rptBarangTersedia.Name = "rptBarangTersedia";
            //this.rptBarangTersedia.ServerReport.BearerToken = null;
            this.rptBarangTersedia.Size = new System.Drawing.Size(832, 514);
            this.rptBarangTersedia.TabIndex = 0;
            this.rptBarangTersedia.Load += new System.EventHandler(this.RptBarangTersedia_Load);
            // 
            // barangTersediaTableAdapter1
            // 
            this.barangTersediaTableAdapter1.ClearBeforeFill = true;
            // 
            // barangTersediaBindingSource
            // 
            this.barangTersediaBindingSource.DataMember = "BarangTersedia";
            this.barangTersediaBindingSource.DataSource = this.db_petshopBarang;
            // 
            // rptBarangTersediaPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(832, 514);
            this.Controls.Add(this.rptBarangTersedia);
            this.Name = "rptBarangTersediaPreview";
            this.Text = "Laporan Barang Tersedia";
            this.Load += new System.EventHandler(this.RptBarangTersediaPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangTersediaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rptBarangTersedia;
        private db_petshopBarang db_petshopBarang;
        private db_petshopBarangTableAdapters.BarangTersediaTableAdapter barangTersediaTableAdapter1;
        private System.Windows.Forms.BindingSource barangTersediaBindingSource;
    }
}