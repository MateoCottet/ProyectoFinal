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

        public List<ONGs> postLogin(int id){
            ONGsRepository repo = new ONGsRepository();
            return repo.postLogin(id);
        }

        public ONGs traerUna(int id) {
            ONGsRepository repo = new ONGsRepository();  
            return repo.traerUna(id);
        }
    }