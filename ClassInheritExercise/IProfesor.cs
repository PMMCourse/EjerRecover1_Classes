using System.Collections.Generic;

namespace ClassInheritExercise
{
    internal interface IProfesor
    {
        string departamento { get; set; }
        List<Asignatura> asignaturas { get; set; }

        void ImpartirAsignatura();
        void CalificarPractica();
        void CalificarExamen();
    }
}