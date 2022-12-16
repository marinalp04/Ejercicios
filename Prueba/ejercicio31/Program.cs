using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio31
{

    class Program

    {

        public static void Main(string[] args)
        {
            int[] numbers = new int[100];

            double suma = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1; 
            }
            
            for (int  i = 0; i < numbers.Length; i++)
            {
                suma += numbers[i];
            }

            Console.WriteLine($"media: {suma /numbers.Length}");
        }

    }
}