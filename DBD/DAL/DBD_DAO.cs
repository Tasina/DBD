using DBD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class DBD_DAO
{
    // Insert your connection string to use below:
    //private string connectionHardy = @"Server=Y50-70\DEV;Database=DBD_Users_Database;User ID=sa;Password=diezel(VH4)";
    private string connectionTasin = @"Server=RLXCW\DEV;Database=DBD_Users_Database;User Id=sa;Password=hej123";
    //private string connectionRasmus = @"Server=Y50-70\DEV;Database=DBD_Users_Database;User ID=sa;Password=diezel(VH4)";


    public bool AddDocument(string documentToAdd)
    {
        using (SqlConnection conn = new SqlConnection(connectionTasin))
        {
            conn.Open();

            string insert = "INSERT INTO Document VALUES(@FullName, @DateCreated)";
            using (SqlCommand command = new SqlCommand(insert, conn))
            {
                SqlParameter documentNameParam = new SqlParameter("@FullName", SqlDbType.NVarChar);
                documentNameParam.Value = documentToAdd;
                command.Parameters.Add(documentNameParam);

                SqlParameter documentDateParam = new SqlParameter("@DateCreated", SqlDbType.Date);
                documentDateParam.Value = DateTime.Now;
                command.Parameters.Add(documentDateParam);

                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
                return false;
            }
        }
    }

    public void RecreateDB()
    {
        using (SqlConnection conn = new SqlConnection(connectionTasin))
        {
            conn.Open();
            string dropAndRecreate = "DROP TABLE Users " +
                                     "CREATE TABLE [Users](Username nvarchar(50)) " +
                                     "INSERT INTO [Users] VALUES ('Tasin') " +
                                     "INSERT INTO [Users] VALUES ('Rasmus') " +
                                     "INSERT INTO [Users] VALUES ('Hardy')";
            using (SqlCommand command = new SqlCommand(dropAndRecreate, conn))
            {
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
    }

    public List<string> GetUsers()
    {
        List<string> AllUsers = new List<string>();

        using (SqlConnection conn = new SqlConnection(connectionTasin))
        {

            conn.Open();
            string getUsers = "SELECT * FROM Users";
            using (SqlCommand command = new SqlCommand(getUsers, conn))
            {
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            AllUsers.Add(dr.GetString(1));
                        }
                    }
                }

                conn.Close();
            }
            return AllUsers;
        }
    }

    public void PreparedStatement_Unprotected(string username)
    {
        List<string> AllUsers = new List<string>();

        using (SqlConnection conn = new SqlConnection(connectionTasin))
        {

            conn.Open();
            string createUser = String.Format("INSERT INTO User(Username) VALUES('{0}')", username);
            using (SqlCommand command = new SqlCommand(createUser, conn))
            {
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
    }

    public List<string> PreparedStatement_Protected(string username)
    {
        List<string> AllUsers = new List<string>();

        using (SqlConnection conn = new SqlConnection(connectionTasin))
        {

            conn.Open();
            string createUser = "INSERT INTO User (Username) VALUES ( ? )"; ;
            using (SqlCommand command = new SqlCommand(createUser, conn))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.ExecuteNonQuery();
                conn.Close();
            }
            return AllUsers;
        }
    }
}