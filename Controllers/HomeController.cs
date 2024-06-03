using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WebApplicationIngematica.Models;

namespace WebApplicationIngematica.Controllers
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
            ViewBag.Message = null;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string email, string telefono, string message)
        {

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(telefono) && !string.IsNullOrEmpty(message))
            {
                ViewBag.Message = "Formulario enviado exitosamente.";
                ModelState.Clear();
            }
            else
            {
                ViewBag.Message = "Error al enviar el formulario. Por favor, verifica los campos.";
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
