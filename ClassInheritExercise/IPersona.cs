namespace ClassInheritExercise
{
    public interface IPersona
    {
        string Apellido { get; set; }
        string Dni { get; set; }
        string Nombre { get; set; }

        void ComprarPan(int cant);
        bool IrDesayuno(bool hambre);
    }
}