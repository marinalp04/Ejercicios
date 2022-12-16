using System;
using System.Globalization;


Console.WriteLine("Introduzca Numero: ");
int Numero = Convert.ToInt32(Console.ReadLine());

Console.ReadLine();
if ((Numero % 2) == 0)

    Console.WriteLine("es par");

else

    Console.WriteLine("es impar");
