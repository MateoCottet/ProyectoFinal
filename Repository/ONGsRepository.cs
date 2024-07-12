using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace ProyectoFinal.Repositories 
{
    public class ONGsRepository
    {
        public List<ONGs> TraerTodas()
        {
            List<ONGs> todasLasOngs = new List<ONGs>();

            string sql = "SELECT * FROM ONGs";

            using(SqlConnection db = BD.GetConnection()) {
                todasLasOngs  = db.Query<ONGs>(sql).ToList();
            }

            return todasLasOngs;
        }
    }
}