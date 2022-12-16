using System;
using System.Globalization;


Console.WriteLine("Introduzca edad: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.ReadLine();


if (age >= 65)
{
    Console.WriteLine("Jubilado");

}
else
{
    if (age < 18)
    {
        Console.WriteLine("Menor de edad");

    }
    else
    {
        if ((age >= 18) && (age < 65))
        {
            Console.WriteLine("Activo");
        }
    }
}
