using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETApp1
{
    public class Singleton
    {
        public List<Alumno> lstAlumnos = new List<Alumno>();
        private static Singleton _instance;

        private Singleton()
        {

        }
        public static Singleton getInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton(); 
            }
            return _instance;
        }
    }
}