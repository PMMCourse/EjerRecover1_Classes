using ClassInheritExercise.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise.interfaces
{
    public interface IProfesor
    {
        string departamento { get; set; }
        int id { get; set; }
        List<Asignatura> asignaturaQueImparte { get; set; }

        void ImparteAsignatura();
        void ExaminaAlumnos();
    }
}
