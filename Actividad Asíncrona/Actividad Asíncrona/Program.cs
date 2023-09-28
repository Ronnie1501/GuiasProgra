using System;

class Program
{
    static void Main()
    {
        string nombre = "Ronnie ";
        string apellido = "Portillo";
        int edad = 19;
        DateTime fechaNacimiento = new DateTime(2004, 1, 15);

        string informacionPersona = "Mi nombre es " + nombre + apellido + "\nTengo: " + edad.ToString() + " años " + "y cumplo el: " + fechaNacimiento.ToString();
Console.WriteLine(informacionPersona);
    }
}
