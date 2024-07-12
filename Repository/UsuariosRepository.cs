using System.Data.SqlClient;
using Dapper;

namespace ProyectoFinal.Repositories 
{
    public class UsuariosRepository
    {
        public Usuarios Login(string email, string clave) {
            Usuarios MiUser = new Usuarios(); 
            string sql = "SELECT * FROM Usuarios WHERE email = @pemail AND clave = @pclave";
            var    parameters = new { pemail = email, pclave = clave };

            using(SqlConnection db = BD.GetConnection()) {
                MiUser = db.QueryFirstOrDefault<Usuarios>(sql, parameters);
            } 
          return MiUser;

        }  
    }
}
/*
public static Usuarios Login(string email, string clave) {
        Usuarios MiUser = new Usuarios();
        
        using(SqlConnection db = new SqlConnection(_connectionString)) {
                string sql = "SELECT * FROM Usuarios WHERE email = @pemail AND clave = @pclave";
                MiUser = db.QueryFirstOrDefault<Usuarios>(sql, new { pemail = email, pclave = clave });
        }
        return MiUser;
    }
    */