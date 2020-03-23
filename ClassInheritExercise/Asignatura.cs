using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Asignatura : IAsignatura
    {
        private string _Nombre;
        private string _IdNombre;
        private Profesor _QuienImparte;
        private int _Horas;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string IdNombre { get => _IdNombre; set => _IdNombre = value; }
        public Profesor QuienImparte { get => _QuienImparte; set => _QuienImparte = value; }
        public int Horas { get => _Horas; set => _Horas = value; }

        public Asignatura(string Nombre, string IdNombre, string QuienImparte, int Horas)
        {
            Nombre = _Nombre;
            IdNombre = _IdNombre;
            Horas = _Horas;
        }
        public Asignatura(Profesor QuienImparte)
        {
            QuienImparte = _QuienImparte;
        }
        public Asignatura() { }
    }
}
