using System.Data.SqlClient;
using Dapper;

public static class BD 
{
    private static string _connectionString = @"Server=localhost;DataBase=UnityCares;Trusted_Connection=True;";


    public static SqlConnection GetConnection() {
        SqlConnection db = new SqlConnection(_connectionString);
        return db;
    }  


}
