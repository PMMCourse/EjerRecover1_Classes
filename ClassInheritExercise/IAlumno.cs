namespace ClassInheritExercise
{
    public interface IAlumno
    {
        int asignatura { get; set; }
        int edad { get; set; }

        bool apruebaExamen();
        bool asisteClase();
    }
}