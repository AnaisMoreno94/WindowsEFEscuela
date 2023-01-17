using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Data
{
    public class DBEscuelaContext:DbContext
    {
        public DBEscuelaContext() : base("keyDB") { }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
    }
}
