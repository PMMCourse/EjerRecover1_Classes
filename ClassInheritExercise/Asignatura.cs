using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Asignatura
    {

        string nombre_asignatura;
        List<Profesor> profesor = new List<Profesor>();

        public Asignatura() { }

        public Asignatura(string nombre_asignatura, List<Profesor> profesor)
        {
            this.nombre_asignatura = nombre_asignatura;
            this.profesor = profesor;
        }

    }
}
