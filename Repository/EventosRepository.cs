using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using ProyectoFinal.Models;

namespace ProyectoFinal.Repositories 
{
    public class EventosRepository
    {
        public List<Eventos> traerEventos(int IdONG)
        {
            List<Eventos> todosLosEventos = new List<Eventos>();
            
            string sql = @"SELECT 
                            id as Id,
                            idONG as IdONG,
                            nombre as Nombre,
                            localidad as Localidad,
                            IdProvincia,
                            fechaEventos as FechaEventos,
                            horaEvento as HoraEvento,
                            cantidadPersonas as CantidadPersonas
                        FROM Eventos 
                        WHERE idONG = @pIdONG 
                        ORDER BY fechaEventos"; 
            
            var parameters = new {pIdONG = IdONG};
            
            using(SqlConnection db = BD.GetConnection()) 
            {
                todosLosEventos = db.Query<Eventos>(sql, parameters).ToList();
            }

            return todosLosEventos;
        }

        // Agregar este método nuevo
        public void CrearEvento(Eventos evento)
        {
            string sql = @"INSERT INTO Eventos (
                            idONG, 
                            nombre, 
                            localidad, 
                            fechaEventos, 
                            horaEvento, 
                            cantidadPersonas
                        ) VALUES (
                            @IdONG,
                            @Nombre,
                            @Localidad,
                            @FechaEventos,
                            @HoraEvento,
                            @CantidadPersonas
                        )";
            
            using(SqlConnection db = BD.GetConnection()) 
            {
                db.Execute(sql, evento);
            }
        }
    }
}