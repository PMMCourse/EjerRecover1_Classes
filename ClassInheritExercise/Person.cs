using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Person
    {

        public string Name { get; set; }
        public string Surnames { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Dni { get; set; }

        public Person()
        {

        }

        public Person(string Name, string Surnames, int Age, string Gender, string Dni)
        {
            this.Name = Name;
            this.Surnames = Surnames;
            this.Age = Age;
            this.Gender = Gender;
            this.Dni = Dni;
        }

    }
}
