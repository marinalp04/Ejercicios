Console.WriteLine("Introduce un número entero");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i < number; i++)
{
    if (i % 2 == 0 && i % 3 == 0)
        Console.WriteLine(i);
}

Console.WriteLine("\nPulsa enter para cerrar");
Console.ReadLine();