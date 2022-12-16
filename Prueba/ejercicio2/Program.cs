using System;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
class hola
{
    static void Main()
    {

        Console.WriteLine("Le voy a hacer una suma, introduzca el primer número");

        double num1, num2, total;

        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduzca el segundo número");

        num2 = Convert.ToDouble(Console.ReadLine());

        total = num1 + num2;

        Console.WriteLine("La suma es " + total);
    }
}
