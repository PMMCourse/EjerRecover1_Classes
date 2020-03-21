using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Persona
    {
        public string nombre { get; set; }
        public string  apellido { get; set; }
        public string dni { get; set; }
        public Persona(string nombre,string apellido,string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        public Persona()
        {

        }
    }
}
