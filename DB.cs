using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyekACS
{
    class DB
    {
        private static string connString = "";
        public static SqlConnection conn = null;
        const string NAMADB = "db_proyekacs";
        public DB()
        {
            try
            {
                string connString = $"Data Source=DESKTOP-GI6P29R\\SQLEXPRESS;Initial Catalog={NAMADB};Integrated Security=True;";
                conn = new SqlConnection(connString);
            }
            catch (Exception exc)
            {
                throw new Exception("Konfigurasi gagal, " + exc.Message.ToString());
            }
        } 
        public static void openConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }
        public static void closeConnection()
        {
            conn.Close();
        }
    }
}