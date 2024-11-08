using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProyectoFinal.Repositories;
using Dapper;

public class EventosService
    {
        public List<Eventos> traerEventos(int IdONG) {
            EventosRepository repo = new EventosRepository();  
            return repo.traerEventos(IdONG);
        } 
    }