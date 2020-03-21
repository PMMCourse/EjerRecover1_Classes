using System;

public class persona:Class1

{
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string dni { get; set; }
    public persona(string nombre,string apellido,string dni)
	{
        this.nombre = nombre;
        this.apellido = apellido;
        this.dni = dni;
	}
    public void desayunar()
    {
        throw new NotImplementedException();
    }
    public void salirAlRecreo()
    {
        throw new NotImplementedException();
    }
}
