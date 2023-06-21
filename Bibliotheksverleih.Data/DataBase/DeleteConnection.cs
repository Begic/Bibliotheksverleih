namespace Bibliotheksverleih.Data.DataBase;

public class DeleteConnection
{
    private readonly string connectionString;

    public DeleteConnection(string connectionString)
    {
        this.connectionString = connectionString;
    }
}