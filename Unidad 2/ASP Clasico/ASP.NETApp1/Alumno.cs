using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETApp1
{
    public class Alumno
    {
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private string _strnumeroControl;

        public string NumeroControl
        {
            get { return _strnumeroControl; }
            set { _strnumeroControl = value; }
        }
        private string _strCarrera;

        public string Carrera
        {
            get { return _strCarrera; }
            set { _strCarrera = value; }
        }

    }
}