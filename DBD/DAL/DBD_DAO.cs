using System;
using System.Data;
using System.Data.SqlClient;

public class DBD_DAO
{
    // Insert your connection string to use below:
    private string connectionHardy = @"Server=Y50-70\DEV;Database=DBD_Users_Database;User ID=sa;Password=diezel(VH4)";
    private string connectionTasin = @"Server=Y50-70\DEV;Database=DBD_Users_Database;User ID=sa;Password=diezel(VH4)";
    private string connectionRasmus = @"Server=Y50-70\DEV;Database=DBD_Users_Database;User ID=sa;Password=diezel(VH4)";


    public bool AddDocument(string documentToAdd)
    {
        //Debug.WriteLine(documentToAdd + " EXIST IN DB : " + doesDocumentExist(documentToAdd));

        if (!doesDocumentExist(documentToAdd))
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
        return false;
    }

    private bool doesDocumentExist(string documentToAdd)
    {
        bool exist = false;

        using (SqlConnection conn = new SqlConnection(connectionHardy))
        {
            conn.Open();

            string select = "SELECT * FROM Document";
            using (SqlCommand command = new SqlCommand(select, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["FullName"].ToString().ToLower().Equals(documentToAdd.ToLower()))
                        {
                            exist = true;
                        }
                    }
                }
            }
            conn.Close();
        }
        return exist;
    }

    public bool AddWord(string wordToAdd)
    {
        using (SqlConnection conn = new SqlConnection(connectionHardy))
        {
            conn.Open();
            string insert = "INSERT INTO Term VALUES(@word)";
            using (SqlCommand command = new SqlCommand(insert, conn))
            {
                SqlParameter wordParam = new SqlParameter("@word", SqlDbType.NVarChar);
                wordParam.Value = wordToAdd;
                command.Parameters.Add(wordParam);

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