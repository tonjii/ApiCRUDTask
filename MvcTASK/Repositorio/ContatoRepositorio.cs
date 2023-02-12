using MVCTask.Data;
using MVCTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCTask.Repositorio

{
    public class ContatoRepositorio : IContatoRepositorio
    {

    private readonly BancoContext _context;


     public ContatoRepositorio(BancoContext bancoContext)
        {
            this._context = bancoContext;
        }

        public ContatoModel ListarPorId(int id)
        {
             return _context.Contato.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _context.Contato.ToList();
        }

        public  ContatoModel Adicionar (ContatoModel contato)
        {
            _context.Contato.Add(contato);
            _context.SaveChanges();
                return contato;


        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);

            if (contatoDB == null) throw new System.Exception("Houve um erro na atualização da tarefa!");

            contatoDB.Nome = contato.Nome;
            contatoDB.Titulo = contato.Titulo;
            contatoDB.Titulo = contato.Titulo;
            contatoDB.Data = contato.Data;
            contatoDB.Inicio = contato.Inicio;
            contatoDB.Fim = contato.Fim;
            contatoDB.Prioridade = contato.Prioridade;
            contatoDB.Finalizado = contato.Finalizado;

            _context.Contato.Update(contatoDB);
            _context.SaveChanges();

            return contatoDB;



        }

        public bool Apagar(int Id)
        {
            ContatoModel contatoDB = ListarPorId(Id);

            if (contatoDB == null) throw new System.Exception("Houve um erro ao deletar a tarefa!");

            _context.Contato.Remove(contatoDB);
            _context.SaveChanges();
            return true;
        }
    }
}
