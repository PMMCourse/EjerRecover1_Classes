using System.Collections.Generic;

namespace ClassInheritExercise
{
    internal interface IAlumno
    {
        string modalidad { get; set; }
        int curso { get; set; }
        char letraCurso { get; set; }
        List<Asignatura> asignaturas { get; set; }

        bool AsisteClase();
        void EntregarTarea();
    }
}