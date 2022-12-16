using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio34
{

    class Program

    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce números separados por comas");
            string numeros = Console.ReadLine();
            string[] numerosDivididos = numeros.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            int [] numerosDeVerdad = new int[numerosDivididos.Length];

            for (int i = 0; i < numerosDeVerdad.Length; i++)
            {
                numerosDeVerdad[i] = int.Parse(numerosDivididos[i]);    
            }

            int max =int.MinValue;
            int min =int.MaxValue;

            foreach (int numero in numerosDeVerdad)
            {
                if (numero > max) max = numero;
                if (numero < min) min = numero;
            }

            Console.WriteLine($"El minimo es {min}");
            Console.WriteLine($"El máximo es {max}");
        }



    }
}