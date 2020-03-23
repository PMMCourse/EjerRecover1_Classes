using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    abstract class Persona
    {
        protected string nombre;
        protected string primerApellido;
        protected string segundoApellido;
        protected string dni;

        public Persona() { }

        public Persona(string nombre, string primerApellido, string segundoApellido, string dni)
        {
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.dni = dni;
        }

        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Dni { get; set; }
    }
}
