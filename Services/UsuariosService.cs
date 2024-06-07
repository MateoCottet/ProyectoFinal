using System.Data.SqlClient;
using Dapper;

public class UsuariosService
{
    public Usuarios Login(string email, string clave) {
        UsuariosRepository repo = new UsuariosRepository();

        return repo.Login(email, clave);
    }  
}
