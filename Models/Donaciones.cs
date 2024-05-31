public class Donaciones
{
   public int id {get; set;}
   public int idUsuario {get; set;}
   public int idONG {get; set;}
   public int idTipoDonacion {get; set;}
   public string descripcion {get; set;}
   public DateTime fecha {get; set;}

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

