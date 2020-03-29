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
        public List<Aula> ClassesAsigned { get; set; }   
        
        public void AprobarSuspender(Profesor teacher, Alumno student, Asignatura subject)
        {  
            foreach(var subjects in student.Asignatures)
            {            
                if(student.Mark >= 5 && student.Mark <= 10 && teacher.Name == subject.Teacher.Name )
                {
                    Console.WriteLine( student.Name + " ha Aprobado" + subjects.Name);
                }
                else
                {
                    Console.WriteLine( student.Name + " ha Suspendido" + subjects.Name);
                }
            }
        }
    }
}

