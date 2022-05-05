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
    public partial class ReportBarangViewer : Form
    {
        public ReportBarangViewer()
        {
            InitializeComponent();
        }

        private void ReportBarangViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_petshopBarang.Barang1' table. You can move, or remove it, as needed.
            this.db_petshopBarang.EnforceConstraints = false;
            this.Barang1TableAdapter.Fill(this.db_petshopBarang.Barang1);
            rptBarangViewer.SetDisplayMode(DisplayMode.PrintLayout);

            this.rptBarangViewer.RefreshReport();
        }
    }
}
