using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PetShop.Global;
using System.Data.SqlClient;

namespace PetShop
{
    public partial class FrmReport : Form
    {
        SqlDataAdapter ad;
        DataSet ds;
        
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void Tampil()
        {
            //SET PROFIT BULANAN INFO TO DATAGRIDVIEW
            dgvPendapatan.DataSource = ds.Tables["ProfitBulanan"];
            dgvPendapatan.Columns[0].DefaultCellStyle.Format = "C2";
            dgvPendapatan.Columns[1].DefaultCellStyle.Format = "C2";
            dgvPendapatan.Columns[0].HeaderText = "Pendapatan Kotor";
            dgvPendapatan.Columns[1].HeaderText = "Pendapatan Bersih";
            dgvPendapatan.Columns[2].HeaderText = "Tahun-Bulan";

            //SET PROFIT HARIAN INFO TO DATAGRIDVIEW
            dgvProfitHarian.DataSource = ds.Tables["ProfitHarian"];
            dgvProfitHarian.Columns[0].DefaultCellStyle.Format = "C2";
            dgvProfitHarian.Columns[1].DefaultCellStyle.Format = "C2";
            dgvPendapatan.Columns[0].HeaderText = "Pendapatan Kotor";
            dgvPendapatan.Columns[1].HeaderText = "Pendapatan Bersih";
            dgvPendapatan.Columns[2].HeaderText = "Tahun-Bulan-Tanggal";


        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            //Get Stock Information
            BuatKoneksi();
            cmd = new SqlCommand("Select sum(stock) as stock from Stock ", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblTotalStock.Text = reader["stock"].ToString();
            }
            else
            {
                lblTotalStock.Text = 0.ToString();
            }

            reader.Close();

            //GET SoldOut Product Informations
            cmd = new SqlCommand("Select sum(qty_jual) as Stock_Terjual from Penjualan_Detail",con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblTStockTerjual.Text = reader["Stock_Terjual"].ToString();
            }
            else
            {
                lblTStockTerjual.Text = 0.ToString();
            }

            reader.Close();

            //GET Sold Product Average per Month
            cmd = new SqlCommand("SELECT AVG(a.sum) AS avgStockTerjual FROM(SELECT sum(t1.qty_jual) AS sum," +
                " MONTH(t2.tgl_transaksi) as mnth FROM Penjualan_Detail t1 inner join Penjualan t2 " +
                "on t1.id_penjualan = t2.id_penjualan GROUP BY MONTH(t2.tgl_transaksi)) AS a", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblRata2Stock.Text = reader["avgStockTerjual"].ToString();
            }
            else
            {
                lblRata2Stock.Text = 0.ToString();
            }

            reader.Close();

            //Get Total of Transaction Information
            cmd = new SqlCommand("Select count(id_penjualan) as Total_Transaksi from Penjualan", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblTotalTransaksi.Text = reader["Total_Transaksi"].ToString();
            }
            else
            {
                lblTotalTransaksi.Text = 0.ToString();
            }

            reader.Close();

            //Get Count Of Transaction For This Month
            cmd = new SqlCommand("Select count(id_penjualan) as TransaksiBulanIni from Penjualan where Month(tgl_transaksi) = Month(GETDATE())", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblJlhTransaksiBlnIni.Text = reader["TransaksiBulanIni"].ToString();
            }
            else
            {
                lblJlhTransaksiBlnIni.Text = 0.ToString();
            }

            reader.Close();


            //Get Average Transaction Count per Month
            cmd = new SqlCommand("SELECT AVG(a.count) AS TransaksiRataRata " +
                " FROM(SELECT count(*) AS count, MONTH(tgl_transaksi) as mnth " +
                "FROM Penjualan GROUP BY MONTH(tgl_transaksi)) AS a", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblRataRataTransaksi.Text = reader["TransaksiRataRata"].ToString();
            }
            else
            {
                lblRataRataTransaksi.Text = 0.ToString();
            }

            reader.Close();

            //GET PROFIT BULANAN DATA
            ds = new DataSet();
            if (ds.Tables["ProfitBulanan"] != null) ds.Tables["ProfitBulanan"].Clear();
            ad = new SqlDataAdapter("Select Sum(t1.sub_total) as Pendapatan_Kotor, sum(t1.harga_jual-t1.harga_beli-t2.potongan)as Pendapatan_Bersih, FORMAT(t2.tgl_transaksi,'yyyy-MM') as Year_Month from Penjualan_Detail t1 inner join Penjualan t2 on t1.id_penjualan = t2.id_penjualan Group By FORMAT(t2.tgl_transaksi, 'yyyy-MM')", con);
            ad.Fill(ds,"ProfitBulanan");

            //Get Biaya
            if (ds.Tables["Biaya"] != null) ds.Tables["Biaya"].Clear();
            ad = new SqlDataAdapter("Select Sum(biaya) as biaya, FORMAT(tgl,'yyyy-MM') as blnThn from BiayaLain Group By FORMAT(tgl,'yyyy-MM')", con);
            ad.Fill(ds,"Biaya");
            

            for(int i=0;i<ds.Tables["ProfitBulanan"].Rows.Count;i++)
            {
                for(int j=0;j<ds.Tables["Biaya"].Rows.Count;j++)
                {
                    if(ds.Tables["Biaya"].Rows[j]["blnThn"].ToString()==ds.Tables["ProfitBulanan"].Rows[i]["Year_Month"].ToString())
                    {
                        ds.Tables["ProfitBulanan"].Rows[i]["Pendapatan_Bersih"] = Convert.ToInt32(ds.Tables["ProfitBulanan"].Rows[i]["Pendapatan_Bersih"]) - Convert.ToInt32(ds.Tables["Biaya"].Rows[j]["biaya"]);
                    }
                }
            }



            //GET PROFIT HARIAN DATA
            if (ds.Tables["ProfitHarian"] != null) ds.Tables["ProfitHarian"].Clear();
            ad = new SqlDataAdapter("Select Sum(t1.sub_total) as Pendapatan_Kotor, sum(t1.harga_jual-t1.harga_beli-t2.potongan)as " +
                "Pendapatan_Bersih, FORMAT(t2.tgl_transaksi,'yyyy-MM-dd') as Tanggal from Penjualan_Detail t1 inner join Penjualan t2 " +
                "on t1.id_penjualan = t2.id_penjualan Group By FORMAT(t2.tgl_transaksi, 'yyyy-MM-dd')", con);
            ad.Fill(ds, "ProfitHarian");
            con.Close();
            Tampil();
        }

        private void BtnLStockBarang_Click(object sender, EventArgs e)
        {
            FrmRptBarang frmRptBarang = new FrmRptBarang();
            frmRptBarang.Show();
        }

        private void BtnLBiayaLain_Click(object sender, EventArgs e)
        {
            frmLapBiayaLain lapBiayaLain = new frmLapBiayaLain();
            lapBiayaLain.ShowDialog();
        }

        private void BtnLPenjualan_Click(object sender, EventArgs e)
        {
            FrmReportPenjualan frmRptPenjualan = new FrmReportPenjualan();
            frmRptPenjualan.ShowDialog();
        }
    }
}
