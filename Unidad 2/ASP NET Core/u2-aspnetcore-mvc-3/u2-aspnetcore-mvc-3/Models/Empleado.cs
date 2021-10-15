using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u2_aspnetcore_mvc_3.Models
{
    public class Empleado
    {
        public int NumeroEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public double Sueldo { get; set; }
        public int HorasTrabajadas { get; set; }
        public string Puesto { get; set; }
    }
}
