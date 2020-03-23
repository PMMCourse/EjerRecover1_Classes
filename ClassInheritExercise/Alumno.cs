using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Alumno : Persona, IAlumno
    {
        public int Matricula { get; set; }
        public string Estudios { get; set; }

        public List<Asignatura> cursando = new List<Asignatura>();

        public Alumno(int matricula, string estudios, List<Asignatura> cursando, string nombre, string apellido, string dni) : base(nombre, apellido, dni)
        {
            Matricula = matricula;
            Estudios = estudios;
            this.cursando = cursando;

            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }

        public Alumno()
        {

        }

        public void EstudiarCosas(IAsignatura a, int tiempoEstudio, IProfesor p, IAlumno f)
        {
            if (tiempoEstudio > 0)
            {
                throw new Exception("Ha estudiado " + a.nombre + " " + tiempoEstudio + " horas") ;
            }
            else
            {
                p.SuspenderCosas(f, true);
            }
        }
        public bool HacerDeberesDeCosas(bool aproElTiempo)
        {
            return aproElTiempo;
        }
        public void MeterseEnDiscord(bool entrar)
        {
            if (entrar == true)
            {
                HacerDeberesDeCosas(false);
            }
            else
            {
                throw new Exception("Se puede aprobar todavia");
            }
            
        }
    }
}
