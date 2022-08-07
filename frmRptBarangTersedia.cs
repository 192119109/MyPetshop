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
    public partial class frmRptBarangTersedia : Form
    {
        public frmRptBarangTersedia()
        {
            InitializeComponent();
        }

        private void FrmRptBarangTersedia_Load(object sender, EventArgs e)
        {
            this.db_petshopBarang.EnforceConstraints = false;
            this.barangTersediaTableAdapter.Fill(this.db_petshopBarang.BarangTersedia);
            rptBarangTersedia.SetDisplayMode(DisplayMode.PrintLayout);
            this.rptBarangTersedia.RefreshReport();
        }
    }
}
