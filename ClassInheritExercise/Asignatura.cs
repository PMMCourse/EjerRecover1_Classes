namespace ClassInheritExercise
{
    public class Asignatura
    {
        private string nombre { get; set; }
        private float precio { get; set; }
        private int horaAsignatura { get; set; }

        public Asignatura() {}

        public Asignatura(string nombre, float precio, int horaAsignatura)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.horaAsignatura = horaAsignatura;
        }
    }
}