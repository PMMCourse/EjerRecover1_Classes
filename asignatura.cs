using System;

public class Asignatura
{
    public int creditos { get; set; }
    public string nombre { get; set; }
    public int horas { get; set; }
    public Asignatura(int creditos, string nombre, int horas)
    {
        this.creditos = creditos;
        this.nombre = nombre;
        this.horas = horas;
    }
}
