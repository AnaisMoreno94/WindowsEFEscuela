using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Dac;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela
{
    public partial class FormAlumno : Form
    {
        public FormAlumno()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Es una trampita, crea un nuevo profesor al mismo tiempo que crea el nuevo Alumno ya que aun no tenemos el Abm De profesor creado o instancias de profesor
            Profesor profesor = new Profesor() { Nombre = "Paco", Apellido = "Perez", Titulo = "Docente"};
            Alumno alumno = new Alumno() { Nombre = textNombre.Text, Apellido = "Perez", FechaNacimiento= new DateTime(1994,10,03), Profesor = profesor};

            int filasAfectadas = AbmAlumno.Insert(alumno);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert OK");
                MostrarTodosAlumnos();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { Nombre = textNombre.Text, AlumnoId = Convert.ToInt32(textId.Text) };

            int filasAfectadas = AbmAlumno.Update(alumno);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update OK");
                MostrarTodosAlumnos();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { Nombre = textNombre.Text, AlumnoId = Convert.ToInt32(textId.Text) };

            int filasAfectadas = AbmAlumno.Delete(alumno);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete OK");
                MostrarTodosAlumnos();
            }

        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textId.Text);
            Alumno alumno = AbmAlumno.SelectWhereById(id);

            MessageBox.Show(alumno.Nombre);
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {
            MostrarTodosAlumnos();
        }
        private void MostrarTodosAlumnos()
        {
            gridAlumno.DataSource = AbmAlumno.SelectAll();
        }
    }
}
