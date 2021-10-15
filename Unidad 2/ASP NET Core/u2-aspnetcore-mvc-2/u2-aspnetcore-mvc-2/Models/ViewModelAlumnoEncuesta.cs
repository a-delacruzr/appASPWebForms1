using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u2_aspnetcore_mvc_2.Models
{
    public class ViewModelAlumnoEncuesta
    {
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strEmail;

        public string Email
        {
            get { return _strEmail; }
            set { _strEmail = value; }
        }

        private string _strCarrera;

        public string Carrera
        {
            get { return _strCarrera; }
            set { _strCarrera = value; }
        }

        private bool _blregresarClases;

        public bool RegresarClases
        {
            get { return _blregresarClases; }
            set { _blregresarClases = value; }
        }


    }
}
