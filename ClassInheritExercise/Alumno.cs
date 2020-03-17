using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Alumno : IAlumno
    {
        private string Curso;
        private int IdCurso;
        private string Faltas;

        public string _curso { get => Curso; set => Curso = value; }
        public int _idCurso { get => IdCurso; set => IdCurso = value; }
        public string _faltas { get => Faltas; set => Faltas = value; }
        public Alumno(string Curso, int IdCurso, string Faltas)
        {
            _curso = Curso;
            _idCurso = IdCurso;
            _faltas = Faltas;
        }
        public Alumno() { }
    }
}
