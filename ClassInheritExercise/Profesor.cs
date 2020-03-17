using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Profesor : Persona, IProfesor
    {
        public string departamento { get; set; }
        public List<Asignatura> asignaturas { get; set; }

        public Profesor() {}

        public Profesor(string departamento, List<Asignatura> asignaturas)
        {
            this.departamento = departamento;
            this.asignaturas = asignaturas;
        }

        public void CalificarExamen() {}

        public void CalificarPractica() {}

        public void ImpartirAsignatura() {}
    }
}
