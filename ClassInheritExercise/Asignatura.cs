using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Asignatura : IAsignatura
    {
        private string Nombre;
        private string IdNombre;
        private string QuienImparte;
        private int Horas;

        public string _nombre { get => Nombre; set => Nombre = value; }
        public string _idNombre { get => IdNombre; set => IdNombre = value; }
        public string _quienImparte { get => QuienImparte; set => QuienImparte = value; }
        public int _horas { get => Horas; set => Horas = value; }

        public Asignatura(string Nombre, string IdNombre, string QuienImparte, int Horas)
        {
            _nombre = Nombre;
            _idNombre = Nombre;
            _quienImparte = QuienImparte;
            _horas = Horas;
        }
        public Asignatura() { }
    }
}
