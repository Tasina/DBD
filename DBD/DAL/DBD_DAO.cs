using System;
using System.Data;
using System.Data.SqlClient;

public class DBD_DAO
{
    // Insert your connection string to use below:
    private string connectionHardy = @"Server=Y50-70\DEV;Database=DBD_Users_Database;User ID=sa;Password=diezel(VH4)";
    //private string connectionTasin = @"Server=Y50-70\DEV;Database=DBD_Users_Database;User ID=sa;Password=diezel(VH4)";
    //private string connectionRasmus = @"Server=Y50-70\DEV;Database=DBD_Users_Database;User ID=sa;Password=diezel(VH4)";


    public void SQLinjection(string injectionString)
    {
        using (SqlConnection conn = new SqlConnection(connectionHardy))
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
        using (SqlConnection conn = new SqlConnection(connectionHardy))
        {
            conn.Open();
            string dropAndRecreate = "DROP TABLE Users " +
                                     "CREATE TABLE [Users](Username nvarchar(50), UserId int) " +
                                     "INSERT INTO [Users] VALUES ('Tasin', 1) " +
                                     "INSERT INTO [Users] VALUES ('Rasmus', 2) " +
                                     "INSERT INTO [Users] VALUES ('Hardy', 3)";
            using (SqlCommand command = new SqlCommand(dropAndRecreate, conn))
            {
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}