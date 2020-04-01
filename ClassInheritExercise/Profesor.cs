using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Profesor : Persona, IProfesor
    {
        string asignatura_impartida, curso;

        public Profesor() { }

        public Profesor(string asignatura_impartida, string curso, string nombre, string apellido1,
            string apellido2, string dni, string direccion)
        {
            this.asignatura_impartida = asignatura_impartida;
            this.curso = curso;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Dni = dni;
            this.Direccion = direccion;
        }

        public string Asignatura_impartida { get => asignatura_impartida; set => asignatura_impartida = value; }
        public string Curso { get => curso; set => curso = value; }

        public bool Asistir()
        {

            return true;
        }

        public void Corregir_examen()
        {

        }

        public void Impartir_clase()
        {

        }
    }
}
