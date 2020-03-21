using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    interface IProfesor
    {
        int numLicencia { get; set; }
        string lugarDondeDaClase { get; set; }
        int numeroAlumnosDocentes { get; set; }

        void AlumnosSuspensos();
      

    }
}
