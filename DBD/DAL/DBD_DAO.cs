using System;
using System.Data;
using System.Data.SqlClient;

public class DBD_DAO
{
    // Insert your connection string to use below:
    private string connectionHardy = @"Server=Y50-70\DEV;Database=DBD_Users_Database;User ID=sa;Password=diezel(VH4)";
    //private string connectionTasin = @"Server=Y50-70\DEV;Database=DBD_Users_Database;User ID=sa;Password=diezel(VH4)";
    //private string connectionRasmus = @"Server=Y50-70\DEV;Database=DBD_Users_Database;User ID=sa;Password=diezel(VH4)";


    public bool AddDocument(string documentToAdd)
    {
        using (SqlConnection conn = new SqlConnection(connectionHardy))
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
        using (SqlConnection conn = new SqlConnection(connectionHardy))
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
}