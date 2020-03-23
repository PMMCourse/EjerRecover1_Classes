using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Profesor : Persona, IProfesor
    {
        private string _Departamento;
        private string _AsignaturaQueDa;
        private string _HorasImpartidas;

        public string Departamento { get => _Departamento; set => _Departamento = value; }
        public string AsignaturaQueDa { get => _AsignaturaQueDa; set => _AsignaturaQueDa = value; }
        public string HorasImpartidas { get => _HorasImpartidas; set => _HorasImpartidas = value; }
        public Profesor(string Departamento, string AsignaturaQueDa, string HorasImpartidas)
        {
            Departamento = _Departamento;
            AsignaturaQueDa = _AsignaturaQueDa;
            HorasImpartidas = _HorasImpartidas;
        }
        public Profesor() { }

        
    }
}
