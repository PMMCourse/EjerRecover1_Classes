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

        public void estudiarCosas() => throw new NotImplementedException();
        public void hacerDeberesDeCosas() => throw new NotImplementedException();
        public void meterseEnDiscord() => throw new NotImplementedException(); //Tenia que poner algo sino reventaba
    }
}
