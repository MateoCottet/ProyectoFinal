using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProyectoFinal.Repositories;
using Dapper;

public class NoticiasService
    {
        public List<Noticias> traerNoticias(int IdONG) {
            NoticiasRepository repo = new NoticiasRepository();  
            return repo.traerNoticias(IdONG);
        } 
    }