using DBD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class DBD_DAO
{
    // Insert your connection string to use below:
    private string connectionString =
      @"Server=Y50-70\DEV;Database=Master;User ID=sa;Password=diezel(VH4)";
    //@"Server=RLXCW\DEV;Database=Master;User Id=sa;Password=hej123";
    //@"Server=Y50-70\DEV;Database=Master;User ID=sa;Password=diezel(VH4)";


    public void SQLinjection(string injectionString)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string selectInjection = "SELECT * FROM [Users] WHERE UserId = " + injectionString;
            using (SqlCommand command = new SqlCommand(selectInjection, conn))
            {
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
    }

    public void RecreateDB()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string dropAndRecreate =
                "IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'DBD_Users') " +
                "CREATE DATABASE DBD_Users " +
                "USE DBD_Users " +
                "IF OBJECT_ID ('Users', 'U') IS NOT NULL " +
                "DROP TABLE Users " +
                "CREATE TABLE[Users](Username nvarchar(50), UserId int) " +
                "INSERT INTO[Users] VALUES('Tasin', 1) " +
                "INSERT INTO[Users] VALUES('Rasmus', 2) " +
                "INSERT INTO[Users] VALUES('Hardy', 3)";
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

        using (SqlConnection conn = new SqlConnection(connectionString))
        {

            conn.Open();
            string getUsers = "USE DBD_Users " +
                              "SELECT * FROM Users";
            using (SqlCommand command = new SqlCommand(getUsers, conn))
            {
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            AllUsers.Add(dr.GetString(0));
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

        using (SqlConnection conn = new SqlConnection(connectionString))
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

        using (SqlConnection conn = new SqlConnection(connectionString))
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