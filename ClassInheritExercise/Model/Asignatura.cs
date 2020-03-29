using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise.Model
{
    public class Asignatura
    {
        public string Name { get; set; }
        public int WeeklyHours { get; set; }
        public int TotalHours { get; set; }
        public Profesor Teacher { get; set; }
    }
}