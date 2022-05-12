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
        public ReportPembelianPreview()
        {
            InitializeComponent();
        }

        private void ReportPembelianPreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_petshopPembelian.DataTable1' table. You can move, or remove it, as needed.
            this.db_petshopPembelian.EnforceConstraints = false;
            this.DataTable1TableAdapter.Fill(this.db_petshopPembelian.DataTable1);
            rptPembelian.SetDisplayMode(DisplayMode.PrintLayout);

            this.rptPembelian.RefreshReport();
        }

        private void RptPembelian_Load(object sender, EventArgs e)
        {

        }
    }
}
