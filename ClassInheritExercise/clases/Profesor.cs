using ClassInheritExercise.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise.clases
{
    public class Profesor : Base, IProfesor
    {
        public string departamento { get; set; }
        public int id { get; set; }
        public List<Asignatura> asignaturaQueImparte { get; set; }

        public Profesor(string departamento, int id, List<Asignatura> asignaturaQueImparte)
        {
            this.departamento = departamento;
            this.id = id;
            this.asignaturaQueImparte = asignaturaQueImparte;
        }

        public void ImparteAsignatura()
        {

        }

        public void ExaminaAlumnos()
        {

        }
    }
}
