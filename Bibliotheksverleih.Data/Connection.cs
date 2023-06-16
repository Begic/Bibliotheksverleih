using System.Data;
using Microsoft.Data.SqlClient;

namespace Bibliotheksverleih.Data
{
    public class Connection
    {
        private string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Bibliothek; Integrated Security=True";

        public void AddWriter(string firstName, string lastName)
        {
            using (var con = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("dbo.insertWriter", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("FName", firstName);
                cmd.Parameters.AddWithValue("LName", lastName);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}