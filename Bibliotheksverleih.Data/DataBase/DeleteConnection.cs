using Bibliotheksverleih.Data.Models;
using Microsoft.Data.SqlClient;

namespace Bibliotheksverleih.Data.DataBase;

public class DeleteConnection
{
    private readonly string connectionString;

    public DeleteConnection(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void DeleteWriter(Writer selectedWriter)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("Delete from Writers Where WriterID = @WriterID", con);
            cmd.Parameters.AddWithValue("@WriterID", selectedWriter.Id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}