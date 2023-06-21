using Bibliotheksverleih.Data.Models;
using Microsoft.Data.SqlClient;

namespace Bibliotheksverleih.Data.DataBase;

public class DbData
{
    private readonly string connectionString;

    public DbData(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<Writer> GetAllWriters()
    {
        var allwriters = new List<Writer>();
        using(var con = new SqlConnection(connectionString))
        {
            var cmd = new SqlCommand("Select * From Writers", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    allwriters.Add(new Writer
                    {
                        Id = (int)reader["WriterID"],
                        FName = (string)reader["FName"],
                        LName = (string)reader["LName"]
                    });
                }
                reader.Close();
            }
        }
        return allwriters;
    }

    public List<Genre> GetAllGenres()
    {
        var allGenres = new List<Genre>();
        using (var con = new SqlConnection(connectionString))
        {
            var cmd = new SqlCommand("Select * From Genres", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    allGenres.Add(new Genre
                    {
                        Id = (int)reader["GenreID"],
                        GenreName = (string)reader["Genre"],
                    });
                }
                reader.Close();
            }
        }
        return allGenres;
    }

    public List<Stock> GetAllStocks()
    {
        var allStocks = new List<Stock>();
        using (var con = new SqlConnection(connectionString))
        {
            var cmd = new SqlCommand("Select * From Stocks", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    allStocks.Add(new Stock
                    {
                        Id = (int)reader["StockID"],
                        Level = (int)reader["Level"],
                        Shelve = (int)reader["Shelve"],
                        Panel = (int)reader["Panel"],
                    });
                }
                reader.Close();
            }
        }
        return allStocks;
    }
}