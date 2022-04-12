namespace PetShop
{
    partial class frmReportBarcode
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AppData = new PetShop.AppData();
            this.BarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BarcodeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PetShop.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // AppData
            // 
            this.AppData.DataSetName = "AppData";
            this.AppData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BarcodeBindingSource
            // 
            this.BarcodeBindingSource.DataMember = "Barcode";
            this.BarcodeBindingSource.DataSource = this.AppData;
            // 
            // frmReportBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.FrmReportBarcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BarcodeBindingSource;
        private AppData AppData;
    }
}