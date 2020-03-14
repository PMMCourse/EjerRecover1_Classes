using System;

public class Alumno: IAlumno,persona
{
    public int Matricula { get; set; }
    public string estudio { get; set; }
    public List<asignatura> curso = new List<asignatura>();
	public Alumno(int matricula,string estudio,list<asignatura>curso,string nombre, string apellido,string dni)
	{
        this.Matricula = matricula;
        this.estudio = estudio;
        this.curso = curso;
        nombre = nombre;
        apellido = apellido;
        dni = dni;
	}
    public void estudiar()
    {
        throw new NotImplementedException();
    }
    public void realizarTareas()
    {
        throw new NotImplementedException();
    }
}
