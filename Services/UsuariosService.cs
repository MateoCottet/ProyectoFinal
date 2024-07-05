using System;
using System.Data.SqlClient;
using ProyectoFinal.Repositories;
using Dapper;


namespace ProyectoFinal.Services
{
    public class UsuariosService
    {
        public Usuarios Login(string email, string clave) {
            UsuariosRepository repo = new UsuariosRepository();
            Console.WriteLine("UsuariosService Email:" + email);  
            return repo.Login(email, clave);
        }  
    }
}
