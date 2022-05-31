namespace PetShop
{
    partial class rptReceiptPreview
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_petshopReceipt = new PetShop.db_petshopReceipt();
            this.rptReceipt = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.db_petshopReceipt;
            // 
            // db_petshopReceipt
            // 
            this.db_petshopReceipt.DataSetName = "db_petshopReceipt";
            this.db_petshopReceipt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptReceipt
            // 
            this.rptReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ds_Receipt";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rptReceipt.LocalReport.DataSources.Add(reportDataSource1);
            this.rptReceipt.LocalReport.ReportEmbeddedResource = "PetShop.rptReceipt.rdlc";
            this.rptReceipt.Location = new System.Drawing.Point(0, 0);
            this.rptReceipt.Name = "rptReceipt";
            this.rptReceipt.ServerReport.BearerToken = null;
            this.rptReceipt.Size = new System.Drawing.Size(680, 536);
            this.rptReceipt.TabIndex = 0;
            // 
            // rptReceiptPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 536);
            this.Controls.Add(this.rptReceipt);
            this.Name = "rptReceiptPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Receipt";
            this.Load += new System.EventHandler(this.RptReceiptPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopReceipt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptReceipt;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private db_petshopReceipt db_petshopReceipt;
    }
}