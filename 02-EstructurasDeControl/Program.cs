Console.WriteLine("=== CONTROL DE FLUJO EN C# ===\n");

// 1. Condicionales (if / else)
Console.Write("Ingresa tus horas de práctica de hoy: ");
string entrada = Console.ReadLine();
double horas = Convert.ToDouble(entrada);

if (horas >= 2.0)
{
    Console.WriteLine("¡Excelente trabajo! Cumpliste tu meta diaria.");
}
else if (horas > 0)
{
    Console.WriteLine("¡Buen avance! Cada minuto cuenta para llegar a junio.");
}
else
{
    Console.WriteLine("Hoy toca descansar o repasar en modo pasivo.");
}

Console.WriteLine("\n-----------------------------------\n");

// 2. Bucles (foreach y for)
string[] tecnologiasMes1 = { "Sintaxis C#", "Variables", "Condicionales", "Bucles", "POO Básica" };

Console.WriteLine("Temas del Mes 1 por completar:");
int contador = 1;

foreach (string tema in tecnologiasMes1)
{
    Console.WriteLine($"{contador}. {tema}");
    contador++;
}

Console.WriteLine("\n¡Simulación de días de práctica completada!");