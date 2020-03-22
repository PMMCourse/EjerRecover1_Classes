namespace ClassInheritExercise
{
    public interface IAlumno
    {
        string Estudios { get; set; }
        int Matricula { get; set; }

        void EstudiarCosas(IAsignatura a, int tiempoEstudio, IProfesor ch);
        bool HacerDeberesDeCosas(bool aproElTiempo);
        void MeterseEnDiscord(bool entrar);
    }
}