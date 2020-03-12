namespace ClassInheritExercise
{
    public interface IAlumno
    {
        string Estudios { get; set; }
        int Matricula { get; set; }

        void estudiarCosas();
        void hacerDeberesDeCosas();
        void meterseEnDiscord();
    }
}