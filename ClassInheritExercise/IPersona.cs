namespace ClassInheritExercise
{
    public interface IPersona
    {
        string Apellido { get; set; }
        string Dni { get; set; }
        string Nombre { get; set; }

        bool AprobarCosas();
        void ComprarPan();
        void IrDesayuno();
        bool SuspenderCosas(IAlumno jc, bool yaMeReireYo);
    }
}