using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Asignatura : IAsignatura
    {
        public string nombre { get; set; }
        public int codigo { get; set; }

        public Asignatura(string nombre, int codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }

        public Asignatura()
        {

        }
    }
}
