using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u2_aspnetcore_mvc_3.Models
{
    public class Datos
    {
        private static List<Empleado> lstEmpleado = new List<Empleado>();

        public static IEnumerable<Empleado> Empleados => lstEmpleado;
        public static void AgregarEmpleado(Empleado miEmpleado)
        {
            lstEmpleado.Add(miEmpleado);
        }
        public static void EiminarEmpleado(Empleado empleado) 
        {
            lstEmpleado.Remove(empleado);
        }
    }
}
