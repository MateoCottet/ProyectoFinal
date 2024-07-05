using System.Data.SqlClient;
using Dapper;

namespace ProyectoFinal.Repositories 
{
    public class UsuariosRepository
    {
        public Usuarios Login(string email, string clave) {
            Usuarios MiUser = new Usuarios();
            Console.WriteLine("UsuariosRepository MiUser:" + MiUser.id);  
            string sql = "SELECT * FROM Usuarios WHERE email = @pemail AND clave = @pclave";
            var    parameters = new { pemail = email, pclave = clave };

            using(SqlConnection db = BD.GetConnection()) {
                MiUser = db.QueryFirstOrDefault<Usuarios>(sql, parameters);
                if (MiUser == null){
                    Console.WriteLine("Mi User NULL");  
                }
            }

            //Console.WriteLine("UsuariosRepository MiUser:" + MiUser.id);  

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