using Microsoft.AspNetCore.Mvc;
using MVCTask.Models;
using MVCTask.Repositorio;
using System;
using System.Collections.Generic;

namespace MVCTask.Controllers
{
    public class ContatoController : Controller
    {

        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }



        public IActionResult Index()
        {
            List<ContatoModel> contato = _contatoRepositorio.BuscarTodos();
            return View(contato);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }


        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Apagar(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
             
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Tarefa cadastrada com sucesso";
                    return RedirectToAction("Index");
                }

                return View(contato);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Não conseguimos efetuar o cadastro da Tarefa, detalhe do erro: {erro.Message} ";
                return RedirectToAction("Index");


            }

           
        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
          if(ModelState.IsValid)
            {
                _contatoRepositorio.Adicionar(contato);
                return RedirectToAction("Index");
            }

            return View("Editar", contato);
        }
    }
}
