using System;

public class ClasePadre
{
    // Atributos de la clase padre
    protected string nombre;
    protected int edad;
    protected string direccion;
    protected double salario;

    // Constructor de la clase padre
    public ClasePadre(string nombre, int edad, string direccion, double salario)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.direccion = direccion;
        this.salario = salario;
    }

    // Método para mostrar los datos de la clase padre
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Dirección: {direccion}");
        Console.WriteLine($"Salario: {salario:C}");
    }

    // Método abstracto que deberán implementar las clases hijas
    public virtual void MetodoAbstracto()
    {
        Console.WriteLine("Método abstracto de la clase padre");
    }
}
