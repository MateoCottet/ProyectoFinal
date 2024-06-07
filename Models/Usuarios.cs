public class Usuarios
{
    public int id { get; set; }
    public int IdPelicula { get; set; }
    public string email { get; set; }
    public string clave { get; set; }
    public string nombreUsuario { get; set; }
    public DateTime fechaNacimiento { get; set; }
    public string Descripcion { get; set; }

    public Usuarios() {
        id = 0;
        IdPelicula = 0;
        email = "";
        clave = "";
        nombreUsuario = "";
        Descripcion = "";
        fechaNacimiento = new DateTime(2019, 12, 5);
    }

    public Usuarios(int Id, string Email, string clave, string NombreUsuario, DateTime FechaNacimiento, string Descripcion)
    {
        id = Id;
        IdPelicula = 0; // No se incluía en el constructor original
        email = Email;
        clave = clave;
        nombreUsuario = NombreUsuario;
        fechaNacimiento = FechaNacimiento;
        Descripcion = Descripcion;
    }
}
