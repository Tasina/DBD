using DBD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class DBD_DAO
{
    // Insert your connection string to use below:
    private string connectionString =
    //@"Server=Y50-70\DEV;Database=Master;User ID=sa;Password=diezel(VH4)";
    @"Server=RLXCW\DEV;Database=Master;User Id=sa;Password=hej123";
    //@"Server=Y50-70\DEV;Database=Master;User ID=sa;Password=diezel(VH4)";


    public List<User> SQLinjection(string injectionString)
    {
        List<User> users = new List<User>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string selectInjection = "USE DBD_Users " +
                                     "SELECT * FROM [Users] WHERE UserId = " + injectionString;
            using (SqlCommand command = new SqlCommand(selectInjection, conn))
            {
                try
                {
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                users.Add(new User() { Id = dr.GetInt32(1), Username = dr.GetString(0) });
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    return users;
                }
                conn.Close();
            }
            return users;
        }
    }

    public void RecreateDB()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string drop =
                "IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'DBD_Users') " +
                "CREATE DATABASE DBD_Users ";
            string recreate =
                "USE DBD_Users " +
                "IF OBJECT_ID ('Users', 'U') IS NOT NULL " +
                "DROP TABLE Users " +
                "CREATE TABLE[Users](Username nvarchar(50), UserId int) " +
                "INSERT INTO[Users] VALUES('Tasin', 1) " +
                "INSERT INTO[Users] VALUES('Rasmus', 2) " +
                "INSERT INTO[Users] VALUES('Hardy', 3)";

            using (SqlCommand dropCommand = new SqlCommand(drop, conn))
            {
                dropCommand.ExecuteNonQuery();
                using (SqlCommand createcommand = new SqlCommand(recreate, conn))
                {
                    createcommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }

    public List<User> GetUsers()
    {
        List<User> AllUsers = new List<User>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {

            conn.Open();
            string getUsers = "USE DBD_Users " +
                              "SELECT * FROM Users";
            using (SqlCommand command = new SqlCommand(getUsers, conn))
            {
                try
                {
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                AllUsers.Add(new User() { Id = dr.GetInt32(1), Username = dr.GetString(0) });
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    return AllUsers;
                }
                conn.Close();
            }
            return AllUsers;
        }
    }









    //Prepared statement
    public List<User> PreparedStatement(string userId)
    {
        List<User> users = new List<User>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string getUser = "USE DBD_Users " +
                             "SELECT * FROM [Users] WHERE UserId = @UserId";
            using (SqlCommand command = new SqlCommand(getUser, conn))
            {
                try
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                users.Add(new User() { Id = dr.GetInt32(1), Username = dr.GetString(0) });
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    return users;
                }
                conn.Close();
            }
            return users;
        }
    }
}