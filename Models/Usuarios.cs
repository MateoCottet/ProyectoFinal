public class Usuarios
{
    public int id { get; set; }

    public string email { get; set; }
    public string clave { get; set; }
    public string nombreUsuario { get; set; }
    public DateTime fechaNacimiento { get; set; }
    public string Descripcion { get; set; }

    public Usuarios() {
        id = 0;
        email = "";
        clave = "";
        nombreUsuario = "";
        Descripcion = "";
        fechaNacimiento = new DateTime(2019, 12, 5);
    }

    public Usuarios(int Id, string Email, string clave, string NombreUsuario, DateTime FechaNacimiento, string Descripcion)
    {
        id = Id;
        email = Email;
        clave = clave;
        nombreUsuario = NombreUsuario;
        fechaNacimiento = FechaNacimiento;
        Descripcion = Descripcion;
    }
}
