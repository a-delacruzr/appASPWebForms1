using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETApp1
{
    public partial class Datos : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno miAlumno = new Alumno();
            miAlumno.NumeroControl = txtNumeroControl.Text;
            miAlumno.Nombre = txtNombre.Text;
            miAlumno.Carrera = ddlCarrera.Text;
            //lblMostrarNoControl.Text = txtNombre.Text + " " + txtNumeroControl.Text + " " + ddlCarrera.Text;
            Singleton.getInstance().lstAlumnos.Add(miAlumno);
            lblMostrarNoControl.Text = "Lista de alumnos: " + Singleton.getInstance().lstAlumnos.Count.ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("numerocontrol");
            dt.Columns.Add("nombre");
            dt.Columns.Add("carrera");
            
            foreach(Alumno alumno in Singleton.getInstance().lstAlumnos)
            {
                dt.Rows.Add(new[] { alumno.NumeroControl, alumno.Nombre, alumno.Carrera });
            }
            gvAlumnos.DataSource = dt;
            gvAlumnos.DataBind();
        }
    }
}