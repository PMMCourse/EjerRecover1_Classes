using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Libros : Asignatura, ILibros
    {
        string _LibrosNombre;
        string _Trimestre;
        int _NumTemas;
        public string LibrosNombre { get => _LibrosNombre; set => _LibrosNombre = value; }
        public string Trimestre { get => _Trimestre; set => _Trimestre = value; }
        public int NumTemas { get => _NumTemas; set => _NumTemas = value; }

        public Libros(string LibrosNombre, string Trimestre, int NumTemas)
        {
            LibrosNombre = _LibrosNombre;
            Trimestre = _Trimestre;
            NumTemas = _NumTemas;
        }
        public Libros() { }

    }
}
