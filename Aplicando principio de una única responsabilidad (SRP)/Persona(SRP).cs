using System;

public class Persona
{
    public string Nombre { get; private set; }
    public int Edad { get; private set; }
    public string Direccion { get; private set; }
    public string CorreoElectronico { get; private set; }

    public Persona(string nombre, int edad, string direccion, string correoElectronico)
    {
        Nombre = nombre;
        Edad = edad;
        Direccion = direccion;
        CorreoElectronico = correoElectronico;
    }
}

public class Impresora
{
    public void ImprimirDatos(Persona persona)
    {
        Console.WriteLine($"Nombre: {persona.Nombre}");
        Console.WriteLine($"Edad: {persona.Edad}");
        Console.WriteLine($"Dirección: {persona.Direccion}");
        Console.WriteLine($"Correo electrónico: {persona.CorreoElectronico}");
    }
}

public class ServicioCorreoElectronico
{
    public void EnviarCorreoElectronico(Persona persona, string mensaje)
    {
        
        Console.WriteLine($"Enviando correo a {persona.CorreoElectronico}: {mensaje}");
    }
}
//a