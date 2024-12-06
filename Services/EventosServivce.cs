using ProyectoFinal.Models;
using ProyectoFinal.Repositories;

namespace ProyectoFinal.Services
{
    public class EventosService
    {
        private EventosRepository _repository;

        public EventosService()
        {
            _repository = new EventosRepository();
        }

        public List<Eventos> traerEventos(int id)
        {
            return _repository.traerEventos(id);
        }

        // Agregar este método nuevo
        public void CrearEvento(Eventos evento)
        {
            _repository.CrearEvento(evento);
        }
    }
}