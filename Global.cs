using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PetShop
{
    class Global
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader reader;

        public static void BuatKoneksi()
        {
            con = new SqlConnection("data source=localhost; initial catalog=db_petshop; integrated security=true");
            con.Open();
        }
    }
}
