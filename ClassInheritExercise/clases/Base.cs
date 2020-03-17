using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise.clases
{
    public class Base
    {
        private string nombre;
        private string apellidos;
        private string dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; } 
        public string Dni { get => dni; set => dni = value; }

        public Base()
        {

        }

        public Base(string nombre, string apellidos, string dni)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni; 
        }

        public void VaAlColegio()
        {

        }



    }
}
