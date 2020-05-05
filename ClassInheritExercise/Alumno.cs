using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Alumno : Persona
    {
        private string id_Matricula;

        public string Id_Matricula
        {
            get { return id_Matricula; }
            set { id_Matricula = value; }
        }

    }
}
