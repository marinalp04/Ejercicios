using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio38
{

    class Program
    {

        public static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                if(i % 2 == 1)Console.WriteLine(numbers[i]);
            }


        }
    }
}
