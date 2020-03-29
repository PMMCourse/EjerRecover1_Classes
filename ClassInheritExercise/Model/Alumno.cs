using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise.Model
{
    public class Alumno : Persona
    {
        public string Curse { get; set; }
        public List<Asignatura> Asignatures { get; set; }
        public Aula Class { get; set; }
        public double Mark { get; set; }

        public void Rezar()
        {
            Console.WriteLine("Rezo para que Chema me apruebe");
        }
    }
}
