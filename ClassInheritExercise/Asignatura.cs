using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Asignatura:IAsignatura
    {
        public string nombre { get; set; }
        
        public string nombreProfesor { get; set; }
       
        List<Alumno> listaAlumnos = new List<Alumno>();

        public int numerosAlumnosSuspensos { get; set; }
        public int numerosAlumnosAprobados { get; set; }
        public void alumnosSupensos()
        {
           foreach(var a in listaAlumnos)
            {
                for(int i = 0; i < listaAlumnos.Count; i++)
                {
                    if (a.notaFinal < 5)
                    {
                        numerosAlumnosSuspensos++;
                    }
                }
            }
        }

        public void alumnosAprobados()
        {
            foreach (var a in listaAlumnos)
            {
                for (int i = 0; i < listaAlumnos.Count; i++)
                {
                    if (a.notaFinal > 5)
                    {
                        numerosAlumnosAprobados++;
                    }
                }
            }
        }
    }
}
