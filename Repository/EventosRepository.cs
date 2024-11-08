using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace ProyectoFinal.Repositories 
{
    public class EventosRepository
    {
        public List<Eventos> traerEventos(int IdONG)
        {
            List<Eventos> todosLosEventos = new List<Eventos>();
            
            string sql = "SELECT * FROM Eventos WHERE IdONG = @pIdONG"; 
            var parameters = new {pIdONG = IdONG};
            using(SqlConnection db = BD.GetConnection()) {
                todosLosEventos = db.Query<Eventos>(sql, parameters).ToList();
            }

            return todosLosEventos;
        }
    }
}