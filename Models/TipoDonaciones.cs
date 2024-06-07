public class TipoDonaciones
{
    public int id {get; set;}
    public string nombre {get; set;}

    public TipoDonaciones()
    {
        id = 0;
        nombre = "";
    }
    public TipoDonaciones(int Id, string Nombre)
    {
        id = Id;
        nombre = Nombre;
    }
}