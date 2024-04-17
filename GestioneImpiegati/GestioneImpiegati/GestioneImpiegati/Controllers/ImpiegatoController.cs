using GestioneImpiegati.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestioneImpiegati.Controllers
{
    public class ImpiegatoController : Controller
    {
        private readonly ILogger<ImpiegatoController> _logger;

        public ImpiegatoController(ILogger<ImpiegatoController> logger)
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
