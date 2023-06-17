using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;

namespace PetShop
{
    class Global
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static string getBarcode = "";
        public static bool checkoutBerhasil = false;
        public static int Dibayarkan;
        public static int Kembalian;
        public static string statusUser;
        public static string user;
        public static string receiptInv;

        //Pembelian
        public static string getIdSup = "", getIdBrg = "";
        public static string getNamaSup = "", getNamaBrg = "";


        public static void BuatKoneksi()
        {
            con = new SqlConnection("data source=localhost; initial catalog=db_petshop; integrated security=true");
            con.Open();
        }

        public static void openConnection(bool y)
        {
            con = new SqlConnection("data source=localhost; initial catalog=db_petshop; integrated security=true");

            if (y)
            {
                if (con != null && con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            else
            {
                con.Close();
            }
        }


        public static bool sendMail(string to, string toName, string body, string subject)
        {
            bool isSuccess = false;
            var fromAddress = new MailAddress("stev3ndavid@gmail.com", "My Petshop Artificial");
            var toAddress = new MailAddress(to, toName);
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "yzfnqedexldwbcmu")
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
            return isSuccess;
        }

        public static bool IsConnectedToInternet()
        {
            string host = "https://www.google.com";  
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch {
                return false;
            }
            return result;
        }

    }
}
