using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public class AbmAlumno
    {
        private static DBEscuelaContext context = new DBEscuelaContext();
        public static List<Alumno> SelectAll()
        {
            return context.Alumnos.ToList();
        }
        public static Alumno SelectWhereById(int id)
        {
            return context.Alumnos.Find(id);
        }
        public static int Insert(Alumno alumno)
        {
            context.Alumnos.Add(alumno);

            return context.SaveChanges();
        }
        public static int Update(Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.AlumnoId);
            alumnoOrigen.Nombre = alumno.Nombre;
            return context.SaveChanges();
        }
        public static int Delete(Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.AlumnoId);
            if (alumnoOrigen != null)
            {
                context.Alumnos.Remove(alumnoOrigen);
                return context.SaveChanges();
            }

            return 0;
        }
    }
}
