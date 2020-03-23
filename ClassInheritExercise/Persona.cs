using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Persona : IPersona
    {
        private string _Nombre;
        private string _Apellido;
        private string _Correo;
        private string _DNI;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string DNI { get => _DNI; set => _DNI = value; }

        public Persona(string Nombre, string Apellido, string Correo, string DNI)
        {
            Nombre = _Nombre;
            Apellido = _Apellido;
            Correo = _Correo;
            DNI = _DNI;
        }
        public Persona() { }

    }
}
