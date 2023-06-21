using System.Data;
using Microsoft.Data.SqlClient;

namespace Bibliotheksverleih.Data.DataBase
{
    public class InsertConnection
    {
        private readonly string connectionString;

        public InsertConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

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

        public void AddGenres(string genre)
        {
            using (var con = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("dbo.insertGenre", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Genre", genre);

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

        public void AddBook()
        {
            //using (var con = new SqlConnection(connectionString))
            //{
            //    var cmd = new SqlCommand("dbo.insertBook", con);

            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@Genre", genre);
            //    cmd.Parameters.AddWithValue("@Genre", genre);
            //    cmd.Parameters.AddWithValue("@Genre", genre);
            //    cmd.Parameters.AddWithValue("@Genre", genre);

            //    try
            //    {
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //        throw;
            //    }
            //}
        }

        public void AddStock(string level, string shelve, string panel)
        {
            using (var con = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("dbo.insertStock", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Level", level);
                cmd.Parameters.AddWithValue("@Shelve", shelve);
                cmd.Parameters.AddWithValue("@Panel", panel);

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