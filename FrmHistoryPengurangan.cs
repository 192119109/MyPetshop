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
    public partial class FrmHistoryPengurangan : Form
    {
        DataSet ds;
        SqlDataAdapter ad;
        public FrmHistoryPengurangan()
        {
            InitializeComponent();
        }

        private void FrmHistoryPengurangan_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            TampilHistoryPengurangan();
            setDataGridView();
        }

        private void TampilHistoryPengurangan()
        {
            BuatKoneksi();
            if (ds.Tables["Pengurangan"] != null) ds.Tables["Pengurangan"].Clear();
            ad = new SqlDataAdapter("Select * from Pengurangan_Stock order by tglPengurangan DESC", con);
            ad.Fill(ds, "Pengurangan");
            con.Close();
        }

        private void setDataGridView()
        {
            dgvHistoryPengurangan.DataSource = ds.Tables["Pengurangan"];
        }
    }
}
