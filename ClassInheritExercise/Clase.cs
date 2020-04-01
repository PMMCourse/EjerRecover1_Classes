using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Clase
    {
        Profesor tutor = new Profesor();
        List<Asignatura> asignaturas = new List<Asignatura>();
        List<Alumno> alumnos = new List<Alumno>();
        //1A, 1B, 2B ETC
        string nombre;

        public Clase() { }

        public Clase(Profesor tutor, List<Asignatura> asignaturas, List<Alumno> alumnos, string nombre)
        {
            this.alumnos = alumnos;
            this.asignaturas = asignaturas;
            this.tutor = tutor;
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal Profesor Tutor { get => tutor; set => tutor = value; }
        internal List<Asignatura> Asignaturas { get => asignaturas; set => asignaturas = value; }
        internal List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
    }
}
