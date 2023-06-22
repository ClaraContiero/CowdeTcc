using MD5Hash;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_cowde.Models;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
namespace mvc_cowde.Controllers
{
    public class UsuarioController : Controller
    {

        const string email1 = "";

        //IActionResult é usado quando se tem um leque de ActionResults possiveis
        //ActionResult representa os códigos de status HTTP.

        //método tipo HttpPost envia dados da máquina para o servidor da aplicação pela url de forma criptografada
        //http é responsavel pela comunição usuário/servidor

        [HttpPost]
        public IActionResult Logar(string email, string senha)
        {

            UsuarioCadastrado uc = new UsuarioCadastrado(email, senha);
            HttpContext.Session.SetString("email1", email);
            Response.Cookies.Append("email1", email);
            //
            CadastroLogin avatarPerfil = CadastroLogin.list_img(email);

            HttpContext.Session.SetString("avatar", avatarPerfil.Avatar);

            if (UsuarioCadastrado.VerificarUsuarios(email, senha) == true)
            {
                //armazenar na sessão
                HttpContext.Session.SetString("user",
                    JsonConvert.SerializeObject(uc));
                TempData["json"] = uc.senha.GetMD5();

                HttpContext.Session.SetString("email",
                    uc.email);


                //guardar em cookie
                Response.Cookies.Append("cowde",
                    JsonConvert.SerializeObject(uc),
                    new CookieOptions()
                    {
                        Expires = DateTime.Now.AddHours(1)
                    });
            }
            else
            {
                return RedirectToAction("Login", "Home");

            }

            return RedirectToAction("Modulos", "Home");

        }

        [HttpPost]
        public IActionResult Atualizar(string nome, string nome_usuario, string email, string imagem)
        {

            email = Response.HttpContext.Session.GetString("email1");

            CadastroLogin usuario = new CadastroLogin(nome, nome_usuario, email);

            TempData["msg"] = usuario.AutualizarModel(email);

            CadastroLogin.salvarAvat(imagem, email);
            HttpContext.Session.SetString("avatar", imagem);

            return RedirectToAction("Perfil", "Home");
        }


        //MÉTODO SAIR DA SESSÃO
        public IActionResult Sair()
        { 
            //remover da sessão
            HttpContext.Session.Remove("user");
            
            //apagar cookie
            Response.Cookies.Delete("cowde");
           
            return RedirectToAction("Index", "Home");
        }

    }
}


