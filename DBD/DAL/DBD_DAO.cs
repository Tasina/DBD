using DBD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DBD_DAO
{
    // Alter below connection-strings to suit your environment:
    private string connectionStringRuntime = @"Server=Y50-70\DEV;Database=Master;User ID=sa;Password=diezel(VH4)";
    private string connectionStringExecute = @"Server=Y50-70\DEV;Database=DBD_Users;User ID=sa;Password=diezel(VH4)";
    
    public void RecreateDB()
    {
        using (SqlConnection conn = new SqlConnection(connectionStringRuntime))
        {
            conn.Open();
            string createDB =
                "IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'DBD_Users') " +
                "CREATE DATABASE DBD_Users ";
            string createTable =
                "USE DBD_Users " +
                "IF OBJECT_ID ('Users', 'U') IS NOT NULL " +
                "DROP TABLE Users " +
                "CREATE TABLE[Users](Username nvarchar(50), UserId int) " +
                "INSERT INTO[Users] VALUES('Tasin', 1) " +
                "INSERT INTO[Users] VALUES('Rasmus', 2) " +
                "INSERT INTO[Users] VALUES('Hardy', 3) ";
            string dropFunction =
                "USE DBD_Users " +
                "IF OBJECT_ID (N'udf_getUser', N'IF') IS NOT NULL " +
                "DROP FUNCTION udf_getUser ";
            string createFunction =
                "CREATE FUNCTION udf_getUser (@Userid int) " +
                "RETURNS TABLE " +
                "AS " +
                "RETURN " +
                "(SELECT UserId, Username FROM Users WHERE UserId = @UserId)";

            using (SqlCommand createDBcommand = new SqlCommand(createDB, conn))
            {
                createDBcommand.ExecuteNonQuery();
                using (SqlCommand createTableCommand = new SqlCommand(createTable, conn))
                {
                    createTableCommand.ExecuteNonQuery();
                    using (SqlCommand dropFunctionCommand = new SqlCommand(dropFunction, conn))
                    {
                        dropFunctionCommand.ExecuteNonQuery();
                        using (SqlCommand createFunctionCommand = new SqlCommand(createFunction, conn))
                        {
                            createFunctionCommand.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
            }
        }
    }
   
    public List<User> PopulateDropdown()
    {
        List<User> users = new List<User>();

        using (SqlConnection conn = new SqlConnection(connectionStringRuntime))
        {
            conn.Open();
            string getUsers = "USE DBD_Users SELECT * FROM Users";

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

    public List<User> PreparedStatement(string userId)
    {
        List<User> users = new List<User>();
        using (SqlConnection conn = new SqlConnection(connectionStringExecute))
        {
            conn.Open();
            string getUser = "SELECT * FROM [Users] WHERE UserId = @UserId";
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

    public List<User> SQLinjection(string injectionString)
    {
        List<User> users = new List<User>();
        using (SqlConnection conn = new SqlConnection(connectionStringExecute))
        {
            conn.Open();
            string selectInjection = "SELECT * FROM [Users] WHERE UserId = " + injectionString;
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

    public List<User> UserDefinedFunction(string id)
    {
        List<User> user = new List<User>();

        using (SqlConnection conn = new SqlConnection(connectionStringExecute))
        {
            conn.Open();
            string executeFunction = "SELECT UserId, Username FROM udf_getUser (" + id + ")";

            using (SqlCommand command = new SqlCommand(executeFunction, conn))
            {
                try
                {
                    using (SqlDataAdapter myAdapter = new SqlDataAdapter(executeFunction, conn))
                    {
                        {
                            DataSet myDataSet = new DataSet();
                            myAdapter.Fill(myDataSet, "User");

                            foreach (DataTable myTable in myDataSet.Tables)
                            {
                                foreach (DataRow myRow in myTable.Rows)
                                {
                                    user.Add(new User()
                                    {
                                        Id = int.Parse(myRow[myTable.Columns[0].ColumnName].ToString()),
                                        Username = myRow[myTable.Columns[1].ColumnName].ToString()
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    conn.Close();
                    return user;
                }
            }
            conn.Close();
        }
        return user;
    }
}