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
        private static string vladDB = "WIN-JT56SL0IR1J";
        private static string sashaDB = "DESKTOP-KSHLJ2B";

        private static readonly SqlConnection sqlConnection = new SqlConnection($@"Data Source = {vladDB}; Initial Catalog = wardrobe; Integrated Security = True");


        public static void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
            
        public static void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}