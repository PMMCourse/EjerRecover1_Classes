﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise.Model
{
    public abstract class Persona
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string DNI { get; set; }  
        
        public void Descanso()
        {
            Console.WriteLine("Salvados por la campana");
        }
    }
}
