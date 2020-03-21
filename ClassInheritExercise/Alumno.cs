using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Alumno : Persona, IAlumno
    {
        public double notaFinal { get; set; }
        public string asignaturaMatriculado { get; set; }

        public Alumno(string nombre, string apellido, string dni, double notaFinal, string asignaturaMatriculado)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.notaFinal = notaFinal;
            this.asignaturaMatriculado = asignaturaMatriculado;

        }
        public Alumno()
        {
            
        }

        public void AprobarExamenes()
        {
            throw new NotImplementedException();
        }

        public void SuspenderExamenes()
        {
            throw new NotImplementedException();
        }
    }
}
