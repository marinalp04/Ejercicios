using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio33
{

    class Program

    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce números separados por comas");
            string numeros = Console.ReadLine();
            string[] numerosDivididos = numeros.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            foreach (string numero in numerosDivididos)
            {
                int number = int.Parse(numero);

                if (number % 2 == 0) Console.WriteLine(number);
            }

        }

       
        
    }
}