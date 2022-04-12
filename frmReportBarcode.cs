using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class frmReportBarcode : Form
    {
        AppData.BarcodeDataTable _barcode;
        public frmReportBarcode(AppData.BarcodeDataTable barcode)
        {
            InitializeComponent();
            this._barcode = barcode;
        }

        private void FrmReportBarcode_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = _barcode;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
