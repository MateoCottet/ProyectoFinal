using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProyectoFinal.Repositories;
using Dapper;



public class ONGsService
    {
        public List<ONGs> TraerTodas() {
            ONGsRepository repo = new ONGsRepository();  
            return repo.TraerTodas();
        }  
    }