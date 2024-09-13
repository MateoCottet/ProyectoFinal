using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace ProyectoFinal.Repositories 
{
    public class NoticiasRepository
    {
        public List<Noticias> traerNoticias(int IdONG)
        {
            List<Noticias> todasLasNoticias = new List<Noticias>();
            
            string sql = "SELECT * FROM Noticias WHERE IdONG = @pIdONG"; 
            var parameters = new {pIdONG = IdONG};
            using(SqlConnection db = BD.GetConnection()) {
                todasLasNoticias = db.Query<Noticias>(sql, parameters).ToList();
            }

            return todasLasNoticias;
        }
    }
}