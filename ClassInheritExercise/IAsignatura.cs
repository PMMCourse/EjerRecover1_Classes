using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    interface IAsignatura
    {
        string nombre { get; set; }
        string nombreProfesor { get; set; }
     
       
        void alumnosSupensos();
        void alumnosAprobados();
    }
}
