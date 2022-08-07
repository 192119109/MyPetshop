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
    public partial class FrmReportBarangDiscontinued : Form
    {
        public FrmReportBarangDiscontinued()
        {
            InitializeComponent();
        }

        private void FrmReportBarangDiscontinued_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_petshopBarang.BarangDiscontinued' table. You can move, or remove it, as needed.
            this.barangDiscontinuedTableAdapter.Fill(this.db_petshopBarang.BarangDiscontinued);
            // TODO: This line of code loads data into the 'db_petshopBarang.Barang1' table. You can move, or remove it, as needed.
            this.Barang1TableAdapter.Fill(this.db_petshopBarang.Barang1);
            rptBarangDiscontinued.SetDisplayMode(DisplayMode.PrintLayout);
            this.rptBarangDiscontinued.RefreshReport();
        }
    }
}
