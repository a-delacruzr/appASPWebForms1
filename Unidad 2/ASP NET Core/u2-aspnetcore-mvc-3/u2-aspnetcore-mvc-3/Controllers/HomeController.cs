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
            if(ModelState.IsValid)
            {
                Datos.AgregarEmpleado(miEmpleado);
                return View("RegistroExitoso", miEmpleado);
            }
            else
            {
                return View();
            }
        }

        public IActionResult ListadoEmpleados()
        {
            return View(Datos.Empleados);
        }

        [HttpGet]
        public IActionResult EditarEmpleado(int numEmpleado)
        {
            Empleado empleado = Datos.Empleados.Where(e => e.NumeroEmpleado == numEmpleado).FirstOrDefault();
            return View(empleado);
        }

        [HttpPost]
        public IActionResult EditarEmpleado(Empleado miEmpleado)
        {
            Empleado empleado = Datos.Empleados.Where(empleado => empleado.NumeroEmpleado == miEmpleado.NumeroEmpleado).FirstOrDefault();
            empleado.NombreCompleto = miEmpleado.NombreCompleto;
            empleado.Puesto = miEmpleado.Puesto;
            empleado.HorasTrabajadas = miEmpleado.HorasTrabajadas;
            empleado.Sueldo = miEmpleado.Sueldo;
            return RedirectToAction("ListadoEmpleados");
        }

        [HttpGet]
        public IActionResult EliminarEmpleado(int numEmpleado)
        {
            Empleado empleado = Datos.Empleados.Where(empleado => empleado.NumeroEmpleado == numEmpleado).FirstOrDefault();
            return View(empleado);
        }

        public IActionResult ConfirmarEliminarEmpleado(int numEmpleado)
        {
            Empleado empleado = Datos.Empleados.Where(empleado => empleado.NumeroEmpleado == numEmpleado).FirstOrDefault();
            Datos.EiminarEmpleado(empleado);
            return RedirectToAction("ListadoEmpleados");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
