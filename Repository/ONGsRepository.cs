using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using ProyectoFinal.Models;

namespace ProyectoFinal.Repositories
{
    public class ONGsRepository
    {
        public List<ONGs> TraerTodas()
        {
            using(SqlConnection db = BD.GetConnection())
            {
                string sql = @"SELECT 
                    id as Id,
                    idUsuario as IdUsuario,
                    nombre as Nombre,
                    logo as Logo,
                    descripcion as Descripcion,
                    domicilio as Domicilio,
                    IdProvincia,
                    Latitud,
                    Longitud
                FROM ONGs";
                return db.Query<ONGs>(sql).ToList();
            }
        }

        public ONGs traerUna(int id)
        {
            using(SqlConnection db = BD.GetConnection())
            {
                string sql = @"SELECT 
                    id as Id,
                    idUsuario as IdUsuario,
                    nombre as Nombre,
                    logo as Logo,
                    descripcion as Descripcion,
                    domicilio as Domicilio,
                    IdProvincia,
                    Latitud,
                    Longitud
                FROM ONGs 
                WHERE id = @pid";
                return db.QueryFirstOrDefault<ONGs>(sql, new { pid = id });
            }
        }

        public List<ONGs> postLogin(int id)
        {
            using(SqlConnection db = BD.GetConnection())
            {
                string sql = @"SELECT 
                    id as Id,
                    idUsuario as IdUsuario,
                    nombre as Nombre,
                    logo as Logo,
                    descripcion as Descripcion,
                    domicilio as Domicilio,
                    IdProvincia,
                    Latitud,
                    Longitud
                FROM ONGs 
                WHERE idUsuario = @pid";
                return db.Query<ONGs>(sql, new { pid = id }).ToList();
            }
        }
    }
}