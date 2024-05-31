public class Noticias 
{
    public int id {get; set;}
    public int idONG {get; set;}
    public string Titulo {get; set;}
    public string Descripcion {get; set;}
    public string Foto {get; set;}
    public DateTime Fecha {get; set;}

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