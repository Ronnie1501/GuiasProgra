//Ejercicio #1

//Valor Truncado
double pi1 = Math.PI;
int Pi_truncado = (int)pi1;
Console.WriteLine("El Valor truncado de PI es: " + Pi_truncado);


//Redondear Arriba
double pi2 = Math.PI;
double RAr = Math.Ceiling(pi2);
Console.WriteLine(" El Valor redondeado hacia arriba de PI es: " + RAr);

//Redondear Abajo
double pi3 = Math.PI;
double RAb = Math.Floor(pi3);
Console.WriteLine("El Valor redondeado hacia abajo de PI es: " + RAb);

//Ejercicio #2

//Redondear
double e = Math.E;
Console.WriteLine("Valor redondeado de E: " + Math.Round(e, 10));


//Ejercicio 3

//Suma

int suma = 0;
for (int i = 1; i <= 20; i++)
{
    suma += i * i;
}
Console.WriteLine(suma);

//Ejercicio 4

//Raíces Cuadradas

Console.WriteLine("---------------Calculadora--------------");
Console.Write("Valor de a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Valor de b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Valor de c: ");
double c = Convert.ToDouble(Console.ReadLine());


double dscrm = (b * b) - (4 * a * c);

if (dscrm > 0)
{
    double raiz1 = (-b + Math.Sqrt(dscrm)) / (2 * a);
    double raiz2 = (-b - Math.Sqrt(dscrm)) / (2 * a);
    Console.WriteLine($"Las raíces son {raiz1} y {raiz2}");
}
else if (dscrm == 0)
{
    double raiz = -b / (2 * a);
    Console.WriteLine($"La raíz doble es {raiz}");
}
else
{
    Console.WriteLine("Las raíces no se pueden calcular");
}
Console.ReadLine();