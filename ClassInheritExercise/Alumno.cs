using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Alumno : Persona, IAlumno
    {
        public int edad { get; set; }
        public int asignatura { get; set; }

        public Alumno(int edad, int asignatura)
        {
            this.edad = edad;
            this.asignatura = asignatura;
        }

        public Alumno()
        {

        }

        public bool asisteClase()
        {
            return false;
        }

        public bool apruebaExamen()
        {
            return false;
        }
    }
}
