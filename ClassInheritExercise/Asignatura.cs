using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    class Asignatura
    {
        protected string nombre;
        protected float precio;
        protected int horaAsignatura;

        public Asignatura() { }

        public Asignatura(string nombre, float precio, int horaAsignatura)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.horaAsignatura = horaAsignatura;
        }

        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int HoraAsignatura { get; set; }
    }
}
