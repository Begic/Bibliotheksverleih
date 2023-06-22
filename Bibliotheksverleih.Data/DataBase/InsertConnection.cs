using System.Data;
using Bibliotheksverleih.Data.Models;
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

        public void AddWriter(Writer writer)
        {
            using (var con = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("dbo.insertWriter", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("FName", writer.FirstName);
                cmd.Parameters.AddWithValue("LName", writer.LastName);

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

        public void AddGenres(Genre genre)
        {
            using (var con = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("dbo.insertGenre", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Genre", genre.GenreName);

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

        public void AddStock(Stock stock)
        {
            using (var con = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("dbo.insertStock", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Level", stock.Level);
                cmd.Parameters.AddWithValue("@Shelve", stock.Shelve);
                cmd.Parameters.AddWithValue("@Panel", stock.Panel);

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