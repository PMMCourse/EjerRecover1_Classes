namespace ClassInheritExercise
{
    public interface IProfesor
    {
        string departamento { get; set; }
        int n_colegiado { get; set; }

        bool corrigeExamen();
        void imparteClase();
    }
}