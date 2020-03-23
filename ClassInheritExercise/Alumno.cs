using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Alumno : IAlumno
    {
        private string _Curso;
        private int _IdCurso;
        private string _Faltas;

        public string Curso { get => _Curso; set => _Curso = value; }
        public int IdCurso { get => _IdCurso; set => _IdCurso = value; }
        public string Faltas { get => _Faltas; set => _Faltas = value; }
        public Alumno(string Curso, int IdCurso, string Faltas)
        {
            Curso = _Curso;
            IdCurso = _IdCurso;
            Faltas = _Faltas;
        }
        public Alumno() { }
    }
}
