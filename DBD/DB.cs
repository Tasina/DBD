using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBD
{
    public class DB
    {

        static string connectionString = "Server=RLXCW/DEV;Database=DBD_Users_Database;User Id=sa;Password=hej123;";
        SqlConnection conn = new SqlConnection(connectionString);

        public void getUsers()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM Users";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            conn.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.

            conn.Close();
        }
    }
}
