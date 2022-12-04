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
    public partial class ReportPenguranganBarangPreview : Form
    {
        DateTime startDate = new DateTime();
        DateTime endDate = new DateTime();
        public ReportPenguranganBarangPreview(DateTime startPeriod, DateTime endPeriod)
        {
            startDate = startPeriod;
            endDate = endPeriod;
            InitializeComponent();
        }

        private void ReportPenguranganBarangPreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_petshopPenguranganStock.Pengurangan_Stock' table. You can move, or remove it, as needed.
            this.db_petshopPenguranganStock.EnforceConstraints = false;
            this.Pengurangan_StockTableAdapter.Fill(this.db_petshopPenguranganStock.Pengurangan_Stock, startDate, endDate);
            rptPenguranganBarang.SetDisplayMode(DisplayMode.PrintLayout);
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("startDate",startDate.Date.ToShortDateString()),
                new Microsoft.Reporting.WinForms.ReportParameter("endDate", endDate.Date.ToShortDateString())
            };
            this.rptPenguranganBarang.LocalReport.SetParameters(rParams);
            this.rptPenguranganBarang.RefreshReport();
        }
    }
}
