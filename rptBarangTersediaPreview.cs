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
    public partial class rptBarangTersediaPreview : Form
    {
        public rptBarangTersediaPreview()
        {
            InitializeComponent();
        }

        private void RptBarangTersediaPreview_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'db_petshopBarang.Barang1' table. You can move, or remove it, as needed.
            this.db_petshopBarang.EnforceConstraints = false;
            this.barangTersediaTableAdapter1.Fill(this.db_petshopBarang.BarangTersedia);
            rptBarangTersedia.SetDisplayMode(DisplayMode.PrintLayout);
            this.rptBarangTersedia.RefreshReport();
        }

        private void RptBarangTersedia_Load(object sender, EventArgs e)
        {

        }

    }
}
