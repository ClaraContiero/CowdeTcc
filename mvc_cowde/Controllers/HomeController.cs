using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_cowde.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_cowde.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Modulos()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }
        public IActionResult Aula()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }

        public IActionResult Aula2()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }

        public IActionResult Aula3()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }

        public IActionResult Aula4()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }

        public IActionResult Introducao()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }
        public IActionResult Introducao2()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }
        public IActionResult Introducao3()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }
        public IActionResult Introducao4()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }
        public IActionResult Questionario()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }

        public IActionResult Questionario2()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }

        public IActionResult Questionario3()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }

        public IActionResult Questionario4()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }

        public IActionResult Teste()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            string email = HttpContext.Session.GetString("email");
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
             return View(CadastroLogin.list_img(email));
        }

        public IActionResult SobreNos()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }

        public IActionResult Editor()
        {
            string teste = HttpContext.Session.GetString("avatar").ToString();
            ViewBag.Avatar = HttpContext.Session.GetString("avatar");
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
