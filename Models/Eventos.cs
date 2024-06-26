public class Eventos
{
    public int id { get; set; }
    public int idONG { get; set; }
    public string nombre { get; set; }
    public string localidad { get; set; }
    public int idProvincia { get; set; }
    public DateTime fechaEventos { get; set; }
    public string horaEvento { get; set; }
    public int cantidadPersonas { get; set; }

    public Eventos() {
        id = 0;
        idONG = 0;
        nombre = "";
        localidad = "";
        horaEvento = "";
        fechaEventos = new DateTime(2019, 2, 2);
        cantidadPersonas = 0;
        idProvincia = 0;
    }

    public Eventos(int Id, int IdONG, string Nombre, string Localidad, int IdProvincia, DateTime FechaEventos, string HoraEvento, int CantidadPersonas)
    {
        id = Id;
        idONG = IdONG;
        nombre = Nombre;
        localidad = Localidad;
        idProvincia = IdProvincia;
        fechaEventos = FechaEventos;
        horaEvento = HoraEvento;
        cantidadPersonas = CantidadPersonas;
    }
}
