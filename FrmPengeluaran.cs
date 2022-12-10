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
    public partial class FrmPengeluaran : Form
    {
        public FrmPengeluaran()
        {
            InitializeComponent();
        }

        private void FrmPengeluaran_Load(object sender, EventArgs e)
        {

        }

        private void BtnPembelian_Click(object sender, EventArgs e)
        {
            FrmReportPembelianPreview frmReportPembelianPreview = new FrmReportPembelianPreview();
            frmReportPembelianPreview.ShowDialog();
        }

        private void BtnBiayaLain_Click(object sender, EventArgs e)
        {
            frmLapBiayaLain lapBiayaLain = new frmLapBiayaLain();
            lapBiayaLain.ShowDialog();
        }

        private void BtnPengurangan_Click(object sender, EventArgs e)
        {
            FrmReportPenguranganBarangPreview frmPenguranganBarangPreview = new FrmReportPenguranganBarangPreview();
            frmPenguranganBarangPreview.ShowDialog();
            
        }

        private void BtnSummary_Click(object sender, EventArgs e)
        {
            FrmPengeluaranSummary frmPengeluaranSummary = new FrmPengeluaranSummary();
            frmPengeluaranSummary.ShowDialog();
        }
    }
}
