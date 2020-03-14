using System;

public class profesor:Persona,IProfesor
{
    public int id { get; set; }
    public string titulacion { get; set; }
    public asignatura asignatura { get; set; }
	public profesor(int id,string titulacion,asignatura asignatura,string nombre, string apellido,string dni)
	{
        this.id = id;
        this.titulacion = titulacion;
        this.asignatura = asignatura;
        nombre = nombre;
        apellido = apellido;
        dni = dni;
	}
    public void aprobarAlumnos()
    {
        throw new NotImplementedException();
    }
    public void darClase()
    {
        throw new NotImplementedException();

    }
    public void suspenderAlumnos()
    {
        throw new NotImplementedException();
    }
}
