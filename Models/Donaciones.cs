public class Donaciones
{
    public int id { get; set; }
    public int idUsuario { get; set; }
    public int idONG { get; set; }
    public int idTipoDonacion { get; set; }
    public string descripcion { get; set; }
    public DateTime fecha { get; set; }

    public Donaciones() {
        id = 0;
        idONG = 0;
        descripcion = "";
        fecha = new DateTime(2019, 2, 1);
        idTipoDonacion = 0;
        idUsuario = 0;
    }

    public Donaciones(int Id, int IdUsuario, int IdONG, int IdTipoDonacion, string Descripcion, DateTime Fecha)
    {
        id = Id;
        idUsuario = IdUsuario;
        idONG = IdONG;
        idTipoDonacion = IdTipoDonacion;
        descripcion = Descripcion;
        fecha = Fecha;
    }
}
