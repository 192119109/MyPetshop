using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PetShop.Global;

namespace PetShop
{
    public partial class frmLapBiayaLain : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        public frmLapBiayaLain()
        {
            InitializeComponent();
        }
        private void Tampil()
        {
            dgvHistoryBL.DataSource = ds.Tables["BiayaLain"];
            dgvHistoryBL.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvHistoryBL.Columns[5].DefaultCellStyle.Format = "c";
            lblJlhRecord.Text = ds.Tables["BiayaLain"].Rows.Count.ToString();
        }
        private void FrmLapBiayaLain_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            if (ds.Tables["BiayaLain"] != null) ds.Tables["BiayaLain"].Clear();
            ad = new SqlDataAdapter("Select * from BiayaLain order by tgl asc", con);
            ad.Fill(ds, "BiayaLain");
            Tampil();
            dgvHistoryBL.AllowUserToAddRows = false;
            dgvHistoryBL.AllowUserToAddRows = false;
            dgvHistoryBL.ReadOnly = true;
            con.Close();
            dtp1.MaxDate = DateTime.Now.Date;
            dtp2.MaxDate = DateTime.Now.Date;
            dtp2.Value = DateTime.Now.Date;

            //filter date
            dtp1.MinDate = Convert.ToDateTime(ds.Tables["BiayaLain"].Rows[0]["tgl"].ToString());
            dtp1.Value = dtp1.MinDate;

            dtp2.MinDate = dtp1.Value;
            GetBiayaBulanIni();
        }

        private void GetBiayaBulanIni()
        {
            BuatKoneksi();
            cmd = new SqlCommand("Select FORMAT(sum(biaya),'#0,0') as Biaya from BiayaLain where Month(tgl) = @Month and YEAR(tgl) = @Year ", con);
            cmd.Parameters.AddWithValue("@Month", DateTime.Now.ToString("MM"));
            cmd.Parameters.AddWithValue("@Year", DateTime.Now.ToString("yyyy"));
            string resPengeluaran = Convert.ToString(cmd.ExecuteScalar());

            //Condition Check
            if (resPengeluaran != null)
            {
                lblPengeluaranBlnIni.Text = resPengeluaran;
            }
            else
            {
                lblPengeluaranBlnIni.Text = 0.ToString();
            }
            con.Close();
        }

        private void Dtp1_ValueChanged(object sender, EventArgs e)
        {
            ds.Tables["BiayaLain"].DefaultView.RowFilter = "tgl >='" + dtp1.Value.Date.ToString("d") + "' and tgl <= '" + dtp2.Value.Date.ToString("d") + " 23:59:59" + "'";
            dtp2.MinDate = dtp1.Value;
            lblJlhRecord.Text = dgvHistoryBL.Rows.Count.ToString();
        }

        private void BtnCetak_Click(object sender, EventArgs e)
        {
            rptBiayaLainPreview frmReportBiayaLain = new rptBiayaLainPreview(dtp1.Value, dtp2.Value);
            frmReportBiayaLain.ShowDialog();
        }
    }
}
