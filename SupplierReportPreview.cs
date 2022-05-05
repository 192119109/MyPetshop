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
    public partial class SupplierReportPreview : Form
    {
        public SupplierReportPreview()
        {
            InitializeComponent();
        }

        private void SupplierReportPreview_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            try
            {
                using (db_petshopEntities1 db = new db_petshopEntities1())
                {
                    supplierBindingSource.DataSource = db.Suppliers.ToList();
                    reportViewer1.RefreshReport();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
