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

namespace wardrobe
{
    public class DataBase
    {
        private const string VladDb = "WIN-JT56SL0IR1J";
        private const string SashaDb = "DESKTOP-KSHLJ2B";

        private static readonly SqlConnection SqlConnection = new SqlConnection($@"Data Source = {SashaDb}; Initial Catalog = wardrobe; Integrated Security = True");

        public static void openConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }
            
        public static void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return SqlConnection;
        }
    }
}