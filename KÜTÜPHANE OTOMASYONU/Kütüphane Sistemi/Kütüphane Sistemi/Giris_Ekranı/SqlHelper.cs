
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;



namespace Giris_Ekranı
{
    public class SqlHelper
    {

        private static string connectionString = "Data Source=DESKTOP-K7MCDTS\\RUMEYSA;Initial Catalog=kütüphane_otomasyonu_sql;Integrated Security=True;";
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open(); // Bağlantıyı aç
            return connection;
        }


    }
}
