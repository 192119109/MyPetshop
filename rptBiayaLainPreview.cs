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
    public partial class rptBiayaLainPreview : Form
    {
        public rptBiayaLainPreview()
        {
            InitializeComponent();
        }

        private void RptBiayaLainPreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_petshopBiayaLain.BiayaLain' table. You can move, or remove it, as needed.
            this.db_petshopBiayaLain.EnforceConstraints = false;
            this.BiayaLainTableAdapter.Fill(this.db_petshopBiayaLain.BiayaLain);
            rptBiayaLain.SetDisplayMode(DisplayMode.PrintLayout);

            this.rptBiayaLain.RefreshReport();
        }
    }
}
