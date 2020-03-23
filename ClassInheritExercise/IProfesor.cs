using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    interface IProfesor
    {
        string departamento { get; set; }
        List<Asignatura> listaAsignaturaProfesor { get; set; }

        void ImpartirAsignatura();
        void CalificarPractica();
        void CalificarExamen();
    }
}
