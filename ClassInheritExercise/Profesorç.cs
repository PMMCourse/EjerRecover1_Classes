using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Profesorç:IProfesor
    {
        public int numLicencia { get; set; }
        public string lugarDondeDaClase { get; set; }
        public int numeroAlumnosDocentes { get; set; }
        public int numeroSuspenso { get; set; }
        List<Alumno> listaAlumnos = new List<Alumno>();

        public void AlumnosSuspensos()
        {
         foreach(var v in listaAlumnos)
            {
               for(int i = 0; i < numeroAlumnosDocentes; i++)
                {
                    if (v.notaFinal < 5)
                    {
                        numeroSuspenso++;
                }
                }
               
            }
        }
    }
}
