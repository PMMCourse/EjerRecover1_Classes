namespace ClassInheritExercise
{
    public interface IAsignatura
    {
        int Horas { get; set; }
        string IdNombre { get; set; }
        string Nombre { get; set; }
        Profesor QuienImparte { get; set; }
    }
}