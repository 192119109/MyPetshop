namespace PetShop
{
    partial class ReportPembelianPreview
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
            this.rptPembelian = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_petshopPembelian = new PetShop.db_petshopPembelian();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new PetShop.db_petshopPembelianTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopPembelian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptPembelian
            // 
            this.rptPembelian.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rptPembelian.LocalReport.DataSources.Add(reportDataSource1);
            this.rptPembelian.LocalReport.ReportEmbeddedResource = "PetShop.ReportPembelian.rdlc";
            this.rptPembelian.Location = new System.Drawing.Point(0, 0);
            this.rptPembelian.Name = "rptPembelian";
            //this.rptPembelian.ServerReport.BearerToken = null;
            this.rptPembelian.Size = new System.Drawing.Size(800, 450);
            this.rptPembelian.TabIndex = 0;
            this.rptPembelian.Load += new System.EventHandler(this.RptPembelian_Load);
            // 
            // db_petshopPembelian
            // 
            this.db_petshopPembelian.DataSetName = "db_petshopPembelian";
            this.db_petshopPembelian.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.db_petshopPembelian;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // ReportPembelianPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptPembelian);
            this.Name = "ReportPembelianPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportPembelianPreview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportPembelianPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopPembelian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptPembelian;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private db_petshopPembelian db_petshopPembelian;
        private db_petshopPembelianTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}