using BdaUai.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BdaUai.Controllers
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

        /*
        //---------------------
        //sfunciones para el cliente cliente
        public IActionResult Prestamos()
        {
            return View();
        }
        public IActionResult ModificarUsuario()
        {
            return View();
        }

        //empleado y administrador
        public IActionResult GestionarUsuarios()
        {
            return View();
        }
        public IActionResult GestionarPrestamos()
        {
            return View();
        }

        //solamente el administrador
        public IActionResult Informes()
        {
            return View();
        }
        public IActionResult ABMLibros()
        {
            return View();
        }

        //-----------------------------
        */

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
