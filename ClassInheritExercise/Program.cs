using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Program
    {
        
        public static void Main(String[] Args)
        {
            Profesor Profesor1 = new Profesor();
            Alumno Alumno1 = new Alumno();

            //Valores Profesor1
            Profesor1.Nombre = "Chema";
            Profesor1.Apellidos = "Montero";
            Profesor1.Edad = 60;
            Profesor1.Dni = "12345678A";
            Profesor1.Asignatura = "PMM";


            //Valores Alumno1
            Alumno1.Nombre = "Fran";
            Alumno1.Apellidos = "Perez";
            Alumno1.Edad = 19;
            Alumno1.Dni = "12345678B";
            Alumno1.Id_Matricula = "aqj34n";       
            
        }
    }
}
