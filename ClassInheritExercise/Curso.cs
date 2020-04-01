using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Curso
    {

        List<Clase> clases = new List<Clase>();
        // Aqui va el grado: Bachiller, primaria, eso etc
        string nombre_curso;

        public Curso() { }

        public Curso(string nombre_curso, List<Clase> clases)
        {
            this.nombre_curso = nombre_curso;
            this.clases = clases;
        }

        public string Nombre_curso { get => nombre_curso; set => nombre_curso = value; }
        internal List<Clase> Clases { get => clases; set => clases = value; }
    }
}
