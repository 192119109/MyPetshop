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
        DateTime Date1,Date2;
        public rptBiayaLainPreview(DateTime dtp1, DateTime dtp2)
        {
            InitializeComponent();
            Date1 = dtp1;
            Date2 = dtp2;
        }

        private void RptBiayaLainPreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_petshopBiayaLain.BiayaLain' table. You can move, or remove it, as needed.
            this.db_petshopBiayaLain.EnforceConstraints = false;
            this.BiayaLainTableAdapter.Fill(this.db_petshopBiayaLain.BiayaLain,Date1,Date2);
            rptBiayaLain.SetDisplayMode(DisplayMode.PrintLayout);

            this.rptBiayaLain.RefreshReport();
        }
    }
}
