//Ejercicio 1
//Caracteres por tamaño

Console.WriteLine("Ingrese una cadena de caracteres:");
string cadena = Console.ReadLine();
if (cadena.Length < 25)
{
    cadena = cadena.PadRight(25, '$');
    Console.WriteLine("La cadena resultante es:");
    Console.WriteLine(cadena);
}
else
{
    Console.WriteLine("La cadena es: " + cadena);
}

//Ejercicio 2
//Funciones Cadenas

Console.WriteLine("Ingrese una cadena de caracteres:");
string C1 = Console.ReadLine();
Console.WriteLine("Ingrese otra cadena de caracteres:");
string C2 = Console.ReadLine();
int ResultadoC = C1.CompareTo(C2);

if (ResultadoC == 0)
{
    Console.WriteLine("Las cadenas son iguales.");
}
else if (ResultadoC < 0)
{
    Console.WriteLine("La primera cadena es diferente que la segunda cadena.");
}
else
{
    Console.WriteLine("La primera cadena es diferente que la segunda cadena.");
}

bool ResultafoI = C1.Equals(C2);

if (ResultafoI)
{
    Console.WriteLine("Las cadenas son iguales.");
}
else
{
    Console.WriteLine("Las cadenas no son iguales.");
}


// ejercicio 3
// Convertir, separar y concatenar

string Frase = "MI MAMA ME MIMA, AMO A MI MAMA";
string FraseMin = Frase.ToLower();
Console.WriteLine("Frase en minúsculas: " + FraseMin);

string[] Palabras = FraseMin.Split(' ');
Console.WriteLine("Palabras separadas:");

foreach (string Palabra in Palabras)
{
    string PalabraRes = Palabra;
    if (Palabra.Length < 3)
    {
        PalabraRes += "%";
    }

    Console.WriteLine(PalabraRes);
}