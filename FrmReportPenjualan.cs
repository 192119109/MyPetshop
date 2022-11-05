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

namespace PetShop
{
    public partial class FrmReportPenjualan : Form
    {
        public FrmReportPenjualan()
        {
            InitializeComponent();
        }

        private void FrmReportPenjualan_Load(object sender, EventArgs e)
        {
            Global.BuatKoneksi();

            dtpPeriodeStart.Value = Convert.ToDateTime("12-1-" + DateTime.Now.Year);
            dtpPeriodeEnd.Value = Convert.ToDateTime($"{DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)}-{DateTime.Now.Month}-{DateTime.Now.Year}");
            cboJenis.SelectedIndex = 0;
            chartPendapatanKotor.Titles.Add("Pendapatan Kotor");
            chartItemTerjual.Titles.Add("Item Terjual");
            chartLaba.Titles.Add("Pendapatan Bersih");
            //showLabaKeuntungan(Convert.ToDateTime(dtpPeriodeStart.Value).Date, Convert.ToDateTime(dtpPeriodeEnd.Value).Date);
        }

        private DateTime getFirstDateTransactionDB()
        {
            DateTime dtOut = DateTime.Now;

            SqlCommand cmd = new SqlCommand("", Global.con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtOut = Convert.ToDateTime(reader["firstPeriod"]).Date;
            }
            return dtOut;
        }

        private DateTime getLastDateTransactionDB()
        {
            DateTime dtOut = DateTime.Now;

            SqlCommand cmd = new SqlCommand("", Global.con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtOut = Convert.ToDateTime(reader["lastPeriod"]).Date;
            }
            return dtOut;
        }

        private void showPendapatanKotor(DateTime startDate, DateTime endDate)
        {
            foreach (var series in chartPendapatanKotor.Series)
            {
                series.Points.Clear();
            }
            int x = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddMonths(1))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_pendapatanKotor(@month,@year)", Global.con);
                cmd.Parameters.AddWithValue("@month", Convert.ToInt32(date.Month));
                cmd.Parameters.AddWithValue("@year", Convert.ToInt32(date.Year));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //chartLaba.Series["Pendapatan"].Points.AddXY(i.ToString(),reader["Laba_Keseluruhan"]);
                    string total = "Rp." + Convert.ToDecimal(reader["pendapatan_kotor"]).ToString("N", new System.Globalization.CultureInfo("is-IS"));
                    chartPendapatanKotor.Series["Pendapatan Kotor"].Points.Add(Convert.ToDouble(reader["pendapatan_kotor"]));
                    chartPendapatanKotor.Series["Pendapatan Kotor"].Points[x].Label = total;
                    chartPendapatanKotor.Series["Pendapatan Kotor"].Points[x].AxisLabel = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(date.Month));
                    chartPendapatanKotor.Series["Pendapatan Kotor"].Points[x].LegendText = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(date.Month));
                    x++;
                }
                reader.Close();
            }
        }

        private void showItemTerjual(DateTime startDate, DateTime endDate)
        {
            foreach (var series in chartItemTerjual.Series)
            {
                series.Points.Clear();
            }
            chartItemTerjual.Series["ItemTerjual"].IsValueShownAsLabel = true;
            //Get Data From Database
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_sumItemTerjual(@startDate,@endDate)", Global.con);
            cmd.Parameters.AddWithValue("@startDate", startDate.Date.ToString("MM-dd-yyyy"));
            cmd.Parameters.AddWithValue("@endDate", endDate.Date.ToString("MM-dd-yyyy"));
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartItemTerjual.Series["ItemTerjual"].Points.AddXY(reader["nama_barang"].ToString(),reader["terjual"]);
            }
            reader.Close();
        }

        private void showLabaKeuntungan(DateTime startDate, DateTime endDate)
        {
            foreach (var series in chartLaba.Series)
            {
                series.Points.Clear();
            }
            int x = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddMonths(1))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_LabaBersihKeseluruhan(@month,@year)", Global.con);
                cmd.Parameters.AddWithValue("@month", Convert.ToInt32(date.Month));
                cmd.Parameters.AddWithValue("@year", Convert.ToInt32(date.Year));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //chartLaba.Series["Pendapatan"].Points.AddXY(i.ToString(),reader["Laba_Keseluruhan"]);
                    string total = "Rp." + Convert.ToDecimal(reader["Laba_Keseluruhan"]).ToString("N", new System.Globalization.CultureInfo("is-IS"));
                    chartLaba.Series["Laba Bersih"].Points.Add(Convert.ToDouble(reader["Laba_Keseluruhan"]));
                    chartLaba.Series["Laba Bersih"].Points[x].Label = total;
                    chartLaba.Series["Laba Bersih"].Points[x].AxisLabel = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(date.Month));
                    chartLaba.Series["Laba Bersih"].Points[x].LegendText = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(date.Month));
                    x++;
                }
                reader.Close();
            }


        }

        private void CboJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboJenis.SelectedIndex == 0)
            {
                showPendapatanKotor(Convert.ToDateTime(dtpPeriodeStart.Value).Date, Convert.ToDateTime(dtpPeriodeEnd.Value).Date);
                showLabaKeuntungan(Convert.ToDateTime(dtpPeriodeStart.Value).Date, Convert.ToDateTime(dtpPeriodeEnd.Value).Date);
                showItemTerjual(Convert.ToDateTime(dtpPeriodeStart.Value).Date, Convert.ToDateTime(dtpPeriodeEnd.Value));
            }
            else if (cboJenis.SelectedIndex == 1)
            {

            }
            else if (cboJenis.SelectedIndex == 2)
            {

            }
        }

        private void DtpPeriodeStart_ValueChanged(object sender, EventArgs e)
        {
            showPendapatanKotor(Convert.ToDateTime(dtpPeriodeStart.Value).Date, Convert.ToDateTime(dtpPeriodeEnd.Value).Date);
            showLabaKeuntungan(Convert.ToDateTime(dtpPeriodeStart.Value).Date, Convert.ToDateTime(dtpPeriodeEnd.Value).Date);
            showItemTerjual(Convert.ToDateTime(dtpPeriodeStart.Value).Date, Convert.ToDateTime(dtpPeriodeEnd.Value));
        }
    }
}
