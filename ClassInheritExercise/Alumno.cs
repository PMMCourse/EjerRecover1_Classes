using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Alumno : Persona, IAlumno
    {
        public string modalidad { get; set; }
        public int curso { get; set; }
        public char letraCurso { get; set; }
        public List<Asignatura> listaAsignaturaAlumno { get; set; }

        public Alumno () { }

        public Alumno(string modalidad, int curso, char letraCurso, List<Asignatura> listaAsignaturaAlumno)
        {
            this.modalidad = modalidad;
            this.curso = curso;
            this.letraCurso = letraCurso;
            this.listaAsignaturaAlumno = listaAsignaturaAlumno;
        }

        public bool AsisteClase()
        {
            return false;
        }

        public void EntregarTarea()
        {
        }
    }
}
