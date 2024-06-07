public class UsuarioActivo {
    public static int Id {get; private set;} = 0;
    public static string Email {get; private set;} = "";
    public static string NombreUsuario {get; private set;} = "";
    public static string clave {get; private set;} = "";
    public static DateTime fechaNacimiento { get; set; }
    public static string Descripcion {get; private set;} = "";
  
    public static void AgregarUser(int id, string email, string clave, string nombreUsuario, DateTime fechaNacimiento, string descripcion)
    {
        Id = id;
        Email = email;
        clave = clave;
        NombreUsuario = nombreUsuario;
        fechaNacimiento = fechaNacimiento;
        Descripcion = descripcion;
    }
    public static Usuarios DevolverUser() {
        Usuarios UsuarioActivo = new Usuarios(Id,Email,clave,NombreUsuario,fechaNacimiento,Descripcion);
        return UsuarioActivo;
    }
}
