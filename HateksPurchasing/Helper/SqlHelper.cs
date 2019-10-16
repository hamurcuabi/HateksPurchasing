using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HateksPurchasing.Helper
{
    public class SqlHelper
    {
        public static String Connection_String = ConfigurationManager.ConnectionStrings["HateksPurchasing.Properties.Settings.HateksPurchasingConnectionString"].ConnectionString;


        public static SqlConnection OpenConnection()
        {
            SqlConnection con = new SqlConnection(Connection_String);
            con.Open();
            return con;
        }

        public static SqlCommand GetSqlCommand(String query, SqlConnection connection)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            return cmd;

        }

        public static SqlDataReader GetSqlDataReader(SqlCommand cmd)
        {
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }
        public static void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }
    }
}
