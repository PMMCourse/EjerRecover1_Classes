using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Libros : Asignatura, ILibros
    {
        string Nombre;
        string Trimestre;
        int NumTemas;
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public string _Trimestre { get => Trimestre; set => Trimestre = value; }
        public int _Numtemas { get => NumTemas; set => NumTemas = value; }

        public Libros(string Nombre, string Trimestre, int NumTemas)
        {
            _Nombre = Nombre;
            _Trimestre = Trimestre;
            _Numtemas = NumTemas;
        }
        public Libros() { }

    }
}
