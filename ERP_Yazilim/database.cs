using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP_Yazilim
{
    class database
    {
        static string cs = "server=.; Initial Catalog=erp;Integrated Security=SSPI";

        public static SqlConnection baglan()
        {
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı Bağlantısı Sorunu! \n HATA: " + ex.Message);
            }

            return con;
        }
    }
}
