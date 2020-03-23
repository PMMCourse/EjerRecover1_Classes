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
        public List<Asignatura> listaAsignaturaProfesor { get; set; }

        public Profesor() { }

        public Profesor(string departamento, List<Asignatura> listaAsignaturaProfesor)
        {
            this.departamento = departamento;
            this.listaAsignaturaProfesor = listaAsignaturaProfesor;
        }

        public void CalificarExamen()
        {
        }

        public void CalificarPractica()
        {
        }

        public void ImpartirAsignatura()
        {
        }
    }
}
