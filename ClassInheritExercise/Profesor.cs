using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Profesor : Persona, IProfesor
    {
        public string departamento { get; set; }
        public int n_colegiado { get; set; }

        public Profesor(string departamento, int n_colegiado)
        {
            this.departamento = departamento;
            this.n_colegiado = n_colegiado;
        }

        public Profesor()
        {

        }

        public void imparteClase()
        {

        }

        public bool corrigeExamen()
        {
            return false;
        }
    }
}
