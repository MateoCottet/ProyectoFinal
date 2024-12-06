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
            ViewBag.id = id;
            return View();
        }

        public IActionResult TraerTodas()
        {
            ONGsService svc = new ONGsService();
            return View();
        }

        public IActionResult traerUna(int id)
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


        [HttpGet]
        [Route("[controller]/Calendario/{id}")]
        public IActionResult Calendario(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Login");
            }
            
            EventosService eventosSvc = new EventosService();
            ViewBag.id = id;
            ViewBag.Eventos = eventosSvc.traerEventos(id);
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login()
        {
            string email = Request.Form["email"];
            string clave = Request.Form["password"];
            
            UsuariosService svc = new UsuariosService();
            Usuarios UsuarioActivo = svc.Login(email, clave);  
            
            if (UsuarioActivo != null)
            {
                ViewBag.Usuarios = UsuarioActivo;
                return RedirectToAction("postLogin", "Home", new { id = UsuarioActivo.id });
            }
            else
            {
                return View("Login");
            }
        }
        
[HttpPost]
public IActionResult CrearEvento(Eventos evento)
{
    if (evento == null)
    {
        return RedirectToAction("Calendario", new { id = evento.IdONG });
    }

    EventosService eventosSvc = new EventosService();
    eventosSvc.CrearEvento(evento);
    
    return RedirectToAction("Calendario", new { id = evento.IdONG });
}
        [HttpGet]
        [Route("Login")]
        public IActionResult LoginGet()
        {
            return View("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

