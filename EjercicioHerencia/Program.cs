class Program
{
    static void Main()
    {
        // Crear instancias de las clases hijas
        ClaseHija1 instanciaHija1 = new ClaseHija1("Juan", 25, "Calle 123", 50000, "Fútbol");
        ClaseHija2 instanciaHija2 = new ClaseHija2("Ana", 30, "Calle 456", 60000, "Ventas");

        // Mostrar datos de las clases hijas
        Console.WriteLine("Datos de ClaseHija1:");
        instanciaHija1.MostrarDatos();
        instanciaHija1.MetodoHija1();
        instanciaHija1.MetodoAbstracto();  // Llamada al método abstracto

        Console.WriteLine("\nDatos de ClaseHija2:");
        instanciaHija2.MostrarDatos();
        instanciaHija2.MetodoHija2();
        instanciaHija2.MetodoAbstracto();  // Llamada al método abstracto
    }
}
