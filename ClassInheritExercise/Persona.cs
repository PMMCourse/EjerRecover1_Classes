using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Persona
    {
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private string dni;

        public Persona() { }

        public Persona(string nombre, string primerApellido, string segundoApellido, string dni)
        {
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.dni = dni;
        }
    }
}
