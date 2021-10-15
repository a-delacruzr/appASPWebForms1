using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u2_aspnetcore_mvc_2.Models
{
    public static class Datos
    {
        private static List<ViewModelAlumnoEncuesta> _lstrespuestas = new List<ViewModelAlumnoEncuesta>();

        public static IEnumerable<ViewModelAlumnoEncuesta> LstRespuestas => _lstrespuestas;
        public static void AgregarRespuesta(ViewModelAlumnoEncuesta respuesta)
        {
            _lstrespuestas.Add(respuesta);
        }

    }
}
