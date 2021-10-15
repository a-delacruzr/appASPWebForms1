using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using u2_aspnetcore_mvc_3.Models;

namespace u2_aspnetcore_mvc_3.Controllers
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

        [HttpGet]
        public IActionResult RegistroEmpleado()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistroEmpleado(Empleado miEmpleado)
        {
            Datos.AgregarEmpleado(miEmpleado);
            return View("RegistroExitoso",miEmpleado);
        }

        public IActionResult ListadoEmpleados()
        {
            return View(Datos.Empleados);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
