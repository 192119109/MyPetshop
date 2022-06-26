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
    public partial class rptBarangHabisPreview : Form
    {
        public rptBarangHabisPreview()
        {
            InitializeComponent();
        }

        private void RptBarangHabis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_petshopBarang.BarangHabis' table. You can move, or remove it, as needed.
            this.db_petshopBarang.EnforceConstraints = false;
            this.barangHabisTableAdapter.Fill(this.db_petshopBarang.BarangHabis);
            rptBarangHabis.SetDisplayMode(DisplayMode.PrintLayout);
            this.rptBarangHabis.RefreshReport();
        }
    }
}
