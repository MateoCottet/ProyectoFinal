using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Models;

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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Login(string email, string clave)
        {
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
