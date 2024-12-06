using System.Data.SqlClient;

namespace ProyectoFinal
{
    public static class BD
    {
        private static string _connectionString = @"Server=localhost;Database=UnityCares;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}