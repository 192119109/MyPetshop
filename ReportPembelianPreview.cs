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
    public partial class ReportPembelianPreview : Form
    {
        DateTime startDate;
        DateTime endDate;
        public ReportPembelianPreview(DateTime Date1, DateTime Date2)
        {
            InitializeComponent();
            startDate = Date1;
            endDate = Date2;
        }

        private void ReportPembelianPreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_petshopPembelian.DataTable1' table. You can move, or remove it, as needed.
            this.db_petshopPembelian.EnforceConstraints = false;
            this.DataTable1TableAdapter.Fill(this.db_petshopPembelian.DataTable1, startDate, endDate);
            rptPembelian.SetDisplayMode(DisplayMode.PrintLayout);

            this.rptPembelian.RefreshReport();
        }
    }
}
