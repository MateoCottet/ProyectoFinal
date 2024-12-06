using ProyectoFinal.Models;
using ProyectoFinal.Repositories;

namespace ProyectoFinal.Services
{
    public class ONGsService
    {
        private ONGsRepository _repository;

        public ONGsService()
        {
            _repository = new ONGsRepository();
        }

        public List<ONGs> TraerTodas()
        {
            return _repository.TraerTodas();
        }

        public ONGs traerUna(int id)
        {
            return _repository.traerUna(id);
        }

        public List<ONGs> postLogin(int id)
        {
            return _repository.postLogin(id);
        }
    }
}