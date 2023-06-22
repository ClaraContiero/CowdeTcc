using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_cowde.Models;

namespace mvc_cowde.Controllers
{
    public class PessoaController : Controller
    {

        // INICIO DO CONTROLLER DE CADASTRAR
        public IActionResult Cadastrar()
        {
            //renderiza uma view (tela) como resposta a todo procedimento encapsulado dentro de Cadastrar
            //esse return vai abrir uma tela de cadastro
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(string nome, string nome_usuario, string email, int idade, int senha)
        {
            //instanciando objeto da classe model de PessoaCadastro
            CadastroLogin pc = new CadastroLogin(nome, nome_usuario, email, idade, senha);
            //objeto da classe de model com o método que cadastra
            TempData["msg"] = pc.CadastrarModel();
            return RedirectToAction("Index", "home");


        }
    }
}

// FIM DO CONTROLLER DE CADASTRAR



