using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise.clases
{
    public class Asignatura
    {
        public string nombre { get; set; }
        public int creditos { get; set; }

        public Asignatura(string nombre, int creditos)
        {
            this.nombre = nombre;
            this.creditos = creditos;
        }

       
    }
}
