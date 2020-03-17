using ClassInheritExercise.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise.interfaces
{
    public interface IAlumno
    {
        List<Asignatura> asignaturasMAtriculadas { get; set; }
        string rama { get; set; }
        int curso { get; set; }
        char letra { get; set; }

        void SeMAtriculaAsignatura();
        void EstudiaAsignatura();
        bool SeDivierte();
    }
}
