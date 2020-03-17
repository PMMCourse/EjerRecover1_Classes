using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Persona : IPersona
    {
        private string Nombre;
        private string Apellido;
        private string Correo;
        private string DNI;

        public string _nombre { get => Nombre; set => Nombre = value; }
        public string _apellido { get => Apellido; set => Apellido = value; }
        public string _correo { get => Correo; set => Correo = value; }
        public string _DNI { get => DNI; set => DNI = value; }

        public Persona(string Nombre, string Apellido, string Correo, string DNI)
        {
            _nombre = Nombre;
            _apellido = Apellido;
            _correo = Correo;
            _DNI = DNI;
        }
        public Persona() {}

    }
}
