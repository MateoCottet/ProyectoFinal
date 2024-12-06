namespace ProyectoFinal.Models
{
    public class Eventos
    {
        public int Id { get; set; }
        public int IdONG { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }
        public int? IdProvincia { get; set; }
        public DateTime FechaEventos { get; set; }
        public string HoraEvento { get; set; }
        public int CantidadPersonas { get; set; }
    }
}