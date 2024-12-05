using Npgsql;


namespace FilMovie.Data
{
    public class DatabaseManager
    {
        string connectionString = "Host=localhost;" + "Port=5432;" + "Database=postgres;" + "Username=postgres;" + "Password=1234";


        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString );
        }

        public void TestConnection()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connexion réussie !");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erreur de connexion : {ex.Message}");
                }
            }
        }
    }
}