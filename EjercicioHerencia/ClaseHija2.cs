using System;

public class ClaseHija2 : ClasePadre
{
    // Atributos adicionales de la clase hija 2
    private string departamento;

    // Constructor de la clase hija 2
    public ClaseHija2(string nombre, int edad, string direccion, double salario, string departamento)
        : base(nombre, edad, direccion, salario)
    {
        this.departamento = departamento;
    }

    // Método específico de la clase hija 2
    public void MetodoHija2()
    {
        Console.WriteLine($"Método específico de ClaseHija2 - Departamento: {departamento}");
    }

    // Implementación del método abstracto
    public override void MetodoAbstracto()
    {
        Console.WriteLine("Implementación del método abstracto en ClaseHija2");
    }
}
