public class Noticias 
{
    public int id { get; set; }
    public int idONG { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public string Foto { get; set; }
    public DateTime Fecha { get; set; }

    public Noticias() {
        id = 0;
        idONG = 0;
        Titulo = "";
        Foto = "";
        Descripcion = "";
        Fecha = new DateTime(2019, 2, 5);
    }

    public Noticias(int Id, int IdONG, string titulo, string descripcion, string foto, DateTime fecha)
    {
        id = Id;
        idONG = IdONG;
        Titulo = titulo;
        Descripcion = descripcion;
        Foto = foto;
        Fecha = fecha;
    }
}
