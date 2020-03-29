using ClassInheritExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aula> classes = new List<Aula>();

            Aula classr = new Aula() { Name = "A1", Chairs = 30, Tables = 10 };

            Profesor teacher = new Profesor();

            List<Asignatura> subjects = new List<Asignatura>();

            subjects.Add(new Asignatura() { Name = "Interfaces" , WeeklyHours = 8, TotalHours = 250 , Teacher = teacher});

            classes.Add(new Aula() { Name = "A1" , Chairs = 30 , Tables = 10 });

            teacher = new Profesor()
            {
                Name = "Juan",
                Surname = "Garcia Pascual",
                Age = 41,
                Asig = subjects,
                ClassesAsigned = classes
            };

            Alumno student = new Alumno()
            {
                Name = "Paco",
                Surname = "Macias Torrijas",
                Age = 20,
                Asignatures = subjects,
                Class = classr,
                Curse = "DAM",
                DNI = "30293819P",
                Mark = 4.5
            };
            Asignatura subject = new Asignatura()
            {
                Name = "Interfaces",
                WeeklyHours = 8,
                TotalHours = 250,
                Teacher = teacher
            };
            student.Rezar();
            teacher.AprobarSuspender(teacher, student, subject);
            teacher.Descanso();
            student.Descanso();
        }
    }
}
