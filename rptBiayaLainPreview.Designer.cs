namespace PetShop
{
    partial class rptBiayaLainPreview
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
            this.BiayaLainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_petshopBiayaLain = new PetShop.db_petshopBiayaLain();
            this.rptBiayaLain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BiayaLainTableAdapter = new PetShop.db_petshopBiayaLainTableAdapters.BiayaLainTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BiayaLainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopBiayaLain)).BeginInit();
            this.SuspendLayout();
            // 
            // BiayaLainBindingSource
            // 
            this.BiayaLainBindingSource.DataMember = "BiayaLain";
            this.BiayaLainBindingSource.DataSource = this.db_petshopBiayaLain;
            // 
            // db_petshopBiayaLain
            // 
            this.db_petshopBiayaLain.DataSetName = "db_petshopBiayaLain";
            this.db_petshopBiayaLain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptBiayaLain
            // 
            this.rptBiayaLain.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsBiayalain";
            reportDataSource2.Value = this.BiayaLainBindingSource;
            this.rptBiayaLain.LocalReport.DataSources.Add(reportDataSource2);
            this.rptBiayaLain.LocalReport.ReportEmbeddedResource = "PetShop.rptBiayaLain.rdlc";
            this.rptBiayaLain.Location = new System.Drawing.Point(0, 0);
            this.rptBiayaLain.Name = "rptBiayaLain";
            this.rptBiayaLain.ServerReport.BearerToken = null;
            this.rptBiayaLain.Size = new System.Drawing.Size(800, 450);
            this.rptBiayaLain.TabIndex = 0;
            // 
            // BiayaLainTableAdapter
            // 
            this.BiayaLainTableAdapter.ClearBeforeFill = true;
            // 
            // rptBiayaLainPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptBiayaLain);
            this.Name = "rptBiayaLainPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Biaya Lain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RptBiayaLainPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BiayaLainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_petshopBiayaLain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBiayaLain;
        private System.Windows.Forms.BindingSource BiayaLainBindingSource;
        private db_petshopBiayaLain db_petshopBiayaLain;
        private db_petshopBiayaLainTableAdapters.BiayaLainTableAdapter BiayaLainTableAdapter;
    }
}