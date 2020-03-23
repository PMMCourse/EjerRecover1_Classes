using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Subject
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public int Hours { get; set; }

        public Subject()
        {

        }

        public Subject(string Name, int Id, int Hours)
        {
            this.Name = Name;
            this.Id = Id;
            this.Hours = Hours;

        }

    }
}
