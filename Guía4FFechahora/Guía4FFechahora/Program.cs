//Ejercicio 1
//Arreglo de años

int[] Años = new int[9] { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };

Console.WriteLine("Cuenta de años bisiestos:");

foreach (int Año in Años)
{
    bool esBisiesto = DateTime.IsLeapYear(Año);
    string Estado = esBisiesto ? "Bisiesto" : "No bisiesto";
    Console.WriteLine($"{Año}: {Estado}");
}

//Ejercicio2 
//Fecha de Pagos

double MontoP = 3000;
int PlazoM = 6;
DateTime Inicio = DateTime.Today;

double Cuota = MontoP / PlazoM;

Console.WriteLine("\n");
Console.WriteLine("Préstamo:");
Console.WriteLine("Monto:" + MontoP);
Console.WriteLine("Plazo en meses:" + PlazoM);
Console.WriteLine("Cuota:" + Cuota, "\n");
Console.WriteLine("Fechas de pago y cuotas:");
for (int i = 0; i < PlazoM; i++)
{
    DateTime fechaPago = Inicio.AddMonths(i);
    Console.WriteLine($"Fecha de pago {i + 1}: {fechaPago.ToShortDateString()} - Cuota: ${Cuota}");
}
Console.WriteLine("\n");

//Ejercicio 3
//Fecha cumpleaños

Console.Write("Ingrese su próxima fecha de cumpleaños en numeros desde el año hasta el dia separados por un guion (YYYY-MM-DD): ");
string FechaCumpleaños = Console.ReadLine();

if (DateTime.TryParse(FechaCumpleaños, out DateTime fechaCumpleaños))
{
    TimeSpan tiempoRestante = fechaCumpleaños - DateTime.Today;
    int DíasR = tiempoRestante.Days;

    Console.WriteLine($"Fecha de cumpleaños ingresada: {fechaCumpleaños.ToShortDateString()}");
    Console.WriteLine($"Días restantes hasta el cumpleaños: {DíasR} días");
}