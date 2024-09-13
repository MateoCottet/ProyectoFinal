//Controller -> Service -> Repository -> DB
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
             ONGsService svc = new ONGsService();
            ViewBag.ONGs = svc.TraerTodas();
            ViewBag.Usuarios = new Usuarios();
            return View();
        }

        public IActionResult postLogin(int id)
        {
            ONGsService svc = new ONGsService();
            ViewBag.ONGsCreadas = svc.postLogin(id);
            return View();
        }
        public IActionResult TraerTodas()
        {
            ONGsService svc = new ONGsService();
            return View();
        }


        /*public IActionResult traerNoticias(int IdONG)
        {
            NoticiasService svc = new NoticiasService();
            ViewBag.Noticias = svc.traerNoticias(IdONG);
            return View("traerUna");
        } */

   public IActionResult traerUna(int id, int IdONG)
   {
        ONGsService ongSvc = new ONGsService();
        NoticiasService noticiasSvc = new NoticiasService();
        ViewBag.UnaONG = ongSvc.traerUna(id);
        ViewBag.id = id;
        ViewBag.Noticias = noticiasSvc.traerNoticias(id);
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
                return RedirectToAction("postLogin", "Home",new {id=UsuarioActivo.id});
            }
            else
            {
                return View("Login"); // Asegúrate de tener una vista llamada Login
            }
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
