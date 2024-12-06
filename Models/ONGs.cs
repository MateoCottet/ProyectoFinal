namespace ProyectoFinal.Models
{
    public class ONGs
    {
        public int Id { get; set; }  // Cambiado de 'id' a 'Id'
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string? Logo { get; set; }
        public string? Descripcion { get; set; }
        public string? Domicilio { get; set; }
        public int? IdProvincia { get; set; }
        public string? Latitud { get; set; }
        public string? Longitud { get; set; }
    }
}