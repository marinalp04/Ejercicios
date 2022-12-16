﻿using System.Globalization;
using System.Timers;

namespace ejercicio24
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Introduce un número entero");
            int filas = int.Parse(Console.ReadLine());  

            for ( int i = 1; i <= filas; i++)
            {
                int spaces = filas - i;

                Console.Write(new String(' ', spaces));

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(Combinatorio(i, j));
                    if (j < i) Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
        

        static int Combinatorio(int m, int n)
        {
            return Factorial(m) / (Factorial(n) * Factorial(m - n));
        }

        static int Factorial(int x)
        {
            int result = 1;

            for (int i = 2; i <= x; i++)
            {
                result *= i; 
            }

            return result;
        }
    }
}
