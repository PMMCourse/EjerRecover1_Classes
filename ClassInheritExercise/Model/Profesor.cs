using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise.Model
{
    public class Profesor : Persona
    {
        public int Id { get; set; }
        public List<Asignatura> Asig { get; set; }
    }
}
