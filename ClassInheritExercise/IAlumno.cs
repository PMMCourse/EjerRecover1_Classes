using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    interface IAlumno
    {
        string modalidad { get; set; }
        int curso { get; set; }
        char letraCurso { get; set; }
        List<Asignatura> listaAsignaturaAlumno { get; set; }

        bool AsisteClase();
        void EntregarTarea();
    }
}
