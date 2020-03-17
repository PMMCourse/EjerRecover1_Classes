using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Profesor : Persona, IProfesor
    {
        private string Departamento;
        private string AsignaturaQueDa;
        private string HorasImpartidas;

        public string _departamento { get => Departamento; set => Departamento = value; }
        public string _asignaturaQueDa { get => AsignaturaQueDa; set => AsignaturaQueDa = value; }
        public string _horasImpartidas { get => HorasImpartidas; set => HorasImpartidas = value; }
        public Profesor(string Departamento, string AsignaturaQueDa, string HorasImpartidas)
        {
            _departamento = Departamento;
            _asignaturaQueDa = AsignaturaQueDa;
            _horasImpartidas = HorasImpartidas;
        }
        public Profesor() { }

    }
}
