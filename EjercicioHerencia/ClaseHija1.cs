using System;

public class ClaseHija1 : ClasePadre
{
    // Atributos adicionales de la clase hija 1
    private string hobby;

    // Constructor de la clase hija 1
    public ClaseHija1(string nombre, int edad, string direccion, double salario, string hobby)
        : base(nombre, edad, direccion, salario)
    {
        this.hobby = hobby;
    }

    // Método específico de la clase hija 1
    public void MetodoHija1()
    {
        Console.WriteLine($"Método específico de ClaseHija1 - Hobby: {hobby}");
    }

    // Implementación del método abstracto
    public override void MetodoAbstracto()
    {
        Console.WriteLine("Implementación del método abstracto en ClaseHija1");
    }
}
