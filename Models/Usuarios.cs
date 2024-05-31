public class Usuarios
{
    public int id {get; set;}
    public string email {get; set;}
    public string clave {get; set;}
    public string nombreUsuario{get; set;}
    public DateTime fechaNacimiento{get; set;}
    public string Descripcion{get; set;}
    public Usuarios(int Id, string Email, string Clave, string NombreUsuario, DateTime FechaNacimiento, string descripcion)
    {
        id = Id;
        email = Email;
        clave = Clave;
        nombreUsuario = NombreUsuario;
        fechaNacimiento = FechaNacimiento;
        Descripcion = descripcion;
    }
}