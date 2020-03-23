using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Asignatura : IAsignatura
    {
        public Asignatura(int creditos, string nombre, int horas)
        {
            this.creditos = creditos;
            this.nombre = nombre;
            this.horas = horas;
        }

        public int creditos { get; set; }
        public string nombre { get; set; }
        public int horas { get; set; }
    }
}
