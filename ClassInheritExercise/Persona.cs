using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Persona : IPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }


        public Persona(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }


        public Persona()
        {
        }

        public void irDesayuno() => throw new NotImplementedException();
        public void comprarPan() => throw new NotImplementedException();
    }
}
