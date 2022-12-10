using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static PetShop.Global;

namespace PetShop
{
    public partial class FrmPengeluaranSummary : Form
    {
        
        public FrmPengeluaranSummary()
        {
            InitializeComponent();
        }

        private void FrmPengeluaranSummary_Load(object sender, EventArgs e)
        {
            dtpStartPeriod.Value = Convert.ToDateTime($"1/1/{DateTime.Now.Year}");
            dtpEndPeriod.Value = DateTime.Now;
            showSummary(dtpStartPeriod.Value,dtpEndPeriod.Value);
        }

        protected void showSummary(DateTime startDate, DateTime endDate)
        {
            if (con != null && con.State == ConnectionState.Closed) BuatKoneksi();
            SqlCommand cmd = new SqlCommand("Select * From f_showSummaryPengeluaran(@startDate,@endDate)",con);
            cmd.Parameters.AddWithValue("@startDate",startDate.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@endDate", endDate.Date.ToString("yyyy-MM-dd"));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblTotalPembelian.Text = $"Rp. {Convert.ToInt64(reader["totalPembelian"]).ToString("N0")}";
                lblTotalBiayaLain.Text = $"Rp. {Convert.ToInt64(reader["totalBiayaLain"]).ToString("N0")}";
                lblTotalPenguranganBarang.Text = $"Rp. {Convert.ToInt64(reader["totalPenguranganBarang"]).ToString("N0")}";
                txtTotal.Text = $"Rp. {(Convert.ToInt64(reader["totalPembelian"])+ Convert.ToInt64(reader["totalBiayaLain"])+ Convert.ToInt64(reader["totalPenguranganBarang"])).ToString("N0")}";
            }
            con.Close();
        }

        private void DtpStartPeriod_ValueChanged(object sender, EventArgs e)
        {
            showSummary(dtpStartPeriod.Value,dtpEndPeriod.Value);
        }
    }
}
