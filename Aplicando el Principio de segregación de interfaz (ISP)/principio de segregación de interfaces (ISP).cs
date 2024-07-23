using System;

// Interfaz con funcion de imprimir
public interface IPrint
{
    void Print(string document);
}

// Interfaz con funcion de escanear
public interface IScan
{
    void Scan(string document);
}

// Clase impresora que solo imprima
public class SimplePrinter : IPrint
{
    public void Print(string document)
    {
        Console.WriteLine($"Printing document: {document}");
    }
}

// Clase para que imprima y escanee
public class MultiFunctionPrinter : IPrint, IScan
{
    public void Print(string document)
    {
        Console.WriteLine($"Printing document: {document}");
    }

    public void Scan(string document)
    {
        Console.WriteLine($"Scanning document: {document}");
    }
}

// Ejemplo para probar implementacion
public class Program
{
    public static void Main()
    {
        IPrint simplePrinter = new SimplePrinter();
        IPrint multiFunctionPrinter = new MultiFunctionPrinter();
        IScan multiFunctionScanner = new MultiFunctionPrinter();

        string document = "Example Document";

        simplePrinter.Print(document);

        multiFunctionPrinter.Print(document);

        multiFunctionScanner.Scan(document);
    }
}
