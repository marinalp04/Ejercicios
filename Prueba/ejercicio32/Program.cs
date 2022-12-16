using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio32
{

    class Program

    {

        public static void Main(string[] args)
        {
            int[] numbers = CrearArray();

            
            Mostrar(numbers);
            
        }

        static int [] CrearArray()
        {

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }

        static void Mostrar(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i} => {numbers[i]}");
            }
        }
    }
}