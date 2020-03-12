using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Profesor : Persona, IProfesor
    {
        public int NumProfesor { get; set; }
        public string titulo { get; set; }
        public Asignatura ProfeDe { get; set; }

        public Profesor(int numProfesor, string titulo, Asignatura profeDe, string nombre, string apellido, string dni) : base(nombre, apellido, dni)
        {
            NumProfesor = numProfesor;
            this.titulo = titulo;
            ProfeDe = profeDe;

            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }

        public void suspenderCosas() => throw new NotImplementedException();
        public void aprobarCosas() => throw new NotImplementedException();
        public void darClasesDeCosas() => throw new NotImplementedException();
    }
}
