namespace ClassInheritExercise
{
    public interface IProfesor
    {
        int NumProfesor { get; set; }
        Asignatura ProfeDe { get; set; }
        string titulo { get; set; }

        bool AprobarCosas();
        void DarClasesDeCosas();
        bool SuspenderCosas(IAlumno jc, bool yaMeReireYo);
    }
}