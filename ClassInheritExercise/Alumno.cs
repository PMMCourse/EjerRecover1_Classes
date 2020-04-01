using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Alumno : Persona, IAlumno
    {
        int numero_matricula;
        string curso, numero_clase;

        public Alumno() { }

        public Alumno(int numero_matricula, string curso, string numero_clase, string nombre, string dni,
            string apellido1, string apellido2, string direccion)
        {
            this.numero_matricula = numero_matricula;
            this.numero_clase = numero_clase;
            this.Nombre = nombre;
            this.curso = curso;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Dni = dni;
            this.Direccion = direccion;

        }

        public int Numero_matricula { get => numero_matricula; set => numero_matricula = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Numero_clase { get => numero_clase; set => numero_clase = value; }

        public bool Asitir()
        {
            return true;
        }

        public void Atender()
        {

        }

        public int Ver_examen(int nota)
        {

            return nota;
        }
    }
}
