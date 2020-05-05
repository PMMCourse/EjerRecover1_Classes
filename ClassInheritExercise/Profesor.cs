using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Profesor : Persona
    {
        private String asignatura;

        public String Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }



    }
}
