public class ONGs
{
    public int id {get; set;}
    public int idUsuario {get; set;}
    public string nombre {get; set;}
    public string logo {get; set;}
    public string descripcion {get; set;}
    public string domicilio {get; set;}
    public int IdProvincia {get; set;}
    public string Latitud {get; set;}
    public string Longitud {get; set;}

    public ONGs(int Id, int IdUsuario, string Nombre, string Logo, string Descripcion, string Domicilio, int idProvincia, string latitud, string longitud)
    {
        id = Id;
        idUsuario = IdUsuario;
        nombre = Nombre;
        logo = Logo;
        descripcion = Descripcion;
        domicilio = Domicilio;
        IdProvincia = idProvincia;
        Latitud = latitud;
        Longitud = longitud;
    }

}