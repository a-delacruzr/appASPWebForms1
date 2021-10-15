using AppASPNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AppASPNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            int hora = DateTime.Now.Hour;
            string saludo = "";
            if (hora < 12)
            {
                saludo = "buenos días!";
            }
            else if (hora < 20)
            {
                saludo = "buenas tardes!";
            }
            else
            {
                saludo = "buenas noches!";
            }
            //return View();
            return View("MiVistaIndex" /*View*/, saludo /*ViewModel*/);
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
