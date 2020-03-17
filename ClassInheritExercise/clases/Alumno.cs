using ClassInheritExercise.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise.clases
{
    public class Alumno : Base, IAlumno
    {
        public List<Asignatura> asignaturasMAtriculadas { get; set; }
        public string rama { get; set; }
        public int curso { get; set; }
        public char letra { get; set; }

        public Alumno(List<Asignatura> asignaturasMAtriculadas, string rama, int curso, char letra)
        {
            this.asignaturasMAtriculadas = asignaturasMAtriculadas;
            this.rama = rama;
            this.curso = curso;
            this.letra = letra;
        }

        public void SeMAtriculaAsignatura()
        {

        }

        public void EstudiaAsignatura()
        {

        }

        public bool SeDivierte()
        {
            return false;
        } 
    }
}
