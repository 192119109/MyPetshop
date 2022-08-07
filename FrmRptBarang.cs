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
    public partial class FrmRptBarang : Form
    {
        public FrmRptBarang()
        {
            InitializeComponent();
        }

        private void FrmRptBarang_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ReportBarangViewer rptBarang = new ReportBarangViewer();
            rptBarang.ShowDialog();
        }

        private void BtnStockHabis_Click(object sender, EventArgs e)
        {
            rptBarangHabisPreview rptBarangHabis = new rptBarangHabisPreview();
            rptBarangHabis.ShowDialog();
        }

        private void BtnStockTersedia_Click(object sender, EventArgs e)
        {
            frmRptBarangTersedia rptBarangTersedia = new frmRptBarangTersedia();
            rptBarangTersedia.ShowDialog();
        }

        private void BtnStockDiscontinued_Click(object sender, EventArgs e)
        {
            FrmReportBarangDiscontinued rptBarangDiscontinued = new FrmReportBarangDiscontinued();
            rptBarangDiscontinued.ShowDialog();
        }
    }
}
