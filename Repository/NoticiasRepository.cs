using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace ProyectoFinal.Repositories 
{
    public class NoticiasRepository
    {
        public List<Noticias> traerNoticias(int id)
        {
            List<Noticias> todasLasNoticias = new List<Noticias>();
            
            string sql = "SELECT * FROM Noticias WHERE IdONG = @pIdONG"; 
            var parameters = new {pIdONG = id};
            using(SqlConnection db = BD.GetConnection()) {
                todasLasNoticias = db.Query<Noticias>(sql, parameters).ToList();
            }

            return todasLasNoticias;
        }
    }
}