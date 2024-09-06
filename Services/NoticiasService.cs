using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProyectoFinal.Repositories;
using Dapper;

public class NoticiasService
    {
        public List<Noticias> traerNoticias(int id) {
            NoticiasRepository repo = new NoticiasRepository();  
            return repo.traerNoticias(id);
        } 
    }