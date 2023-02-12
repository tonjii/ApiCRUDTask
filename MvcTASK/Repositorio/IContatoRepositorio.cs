using MVCTask.Data;
using MVCTask.Models;
using System;
using System.Collections.Generic;

namespace MVCTask.Repositorio
{
    public interface IContatoRepositorio
    {

        ContatoModel ListarPorId(int id);
        
        List<ContatoModel> BuscarTodos();
            
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);

        bool Apagar(int Id);

        //Gravar no banco de dados 
    }
}
