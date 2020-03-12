namespace ClassInheritExercise
{
    public interface IProfesor
    {
        int NumProfesor { get; set; }
        Asignatura ProfeDe { get; set; }
        string titulo { get; set; }

        void aprobarCosas();
        void darClasesDeCosas();
        void suspenderCosas();
    }
}