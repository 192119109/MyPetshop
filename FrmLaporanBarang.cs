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
    public partial class FrmLaporanBarang : Form
    {
        public FrmLaporanBarang()
        {
            InitializeComponent();
        }

        private void BtnAllStock_Click(object sender, EventArgs e)
        {
            ReportBarangViewer rptBarang = new ReportBarangViewer();
            rptBarang.ShowDialog();
        }

        private void BtnStockHabis_Click(object sender, EventArgs e)
        {
            rptBarangHabisPreview rptBarangHabis = new rptBarangHabisPreview();
            rptBarangHabis.ShowDialog();
        }
    }
}
