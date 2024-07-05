using System.Diagnostics;
using System;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Models;
using ProyectoFinal.Services;

namespace ProyectoFinal.Controllers
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
            ViewBag.Usuario = new Usuarios();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost("Login")]
        public IActionResult Login()
        {
            string email, clave;
            email = Request.Form["email"];
            clave = Request.Form["password"];
            
            UsuariosService svc = new UsuariosService();
            Usuarios UsuarioActivo = svc.Login(email, clave);  
            
            if (UsuarioActivo != null)
            {
                // Asigna el usuario activo a la ViewBag para usarlo en la vista
                ViewBag.Usuarios = UsuarioActivo;
                return View("Index");
            }
            else
            {
                return View("Login"); // Asegúrate de tener una vista llamada Login
            }
        }
        public IActionResult TraerOng(string Ong)
    {
        ViewBag.Card = BD.MisCards("Select * from Card where IdCard = " + O)[0];    
    }
         [HttpGet("Login")]
        public IActionResult LoginGet()
        {
            return View("Login"); // Asegúrate de tener una vista llamada Login
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
