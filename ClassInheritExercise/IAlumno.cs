using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public interface IAlumno
    {
        double notaFinal { get; set; }
        string asignaturaMatriculado { get; set; }
        void AprobarExamenes();
        void SuspenderExamenes();
    }
}
