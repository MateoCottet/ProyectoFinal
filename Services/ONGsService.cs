using System;
using System.Data.SqlClient;
using ProyectoFinal.Repositories;
using Dapper;


namespace ProyectoFinal.Services
{
    public class ONGsService
    {
        public ONGs TraerOng(string nombre, string logo) {
            ONGsRepository repo = new ONGsRepository();  
            return repo.TraerOng(nombre, logo);
        }  
    }
}
