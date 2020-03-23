namespace ClassInheritExercise
{
    public interface IAlumno
    {
        string Estudios { get; set; }
        int Matricula { get; set; }

        void EstudiarCosas(IAsignatura a, int tiempoEstudio, IProfesor p, IAlumno f);
        bool HacerDeberesDeCosas(bool aproElTiempo);
        void MeterseEnDiscord(bool entrar);
    }
}