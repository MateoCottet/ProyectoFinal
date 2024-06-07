public class Provincias
{
    public int Id {get; set;}
    public string Nombre {get; set;}

    public Provincias()
    {
        Id = 0;
        Nombre = "";
    }

    public Provincias(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }
}