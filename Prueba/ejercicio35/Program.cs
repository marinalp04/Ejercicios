using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio35
{

    class Program
    {
        //static readonly char[] LETTERS = new { '' };
        const string LETTERS = "TRWAGMYFPDXBNJZSQVHLCKE";

        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu DNI sin la letra");
            int dni = int.Parse(Console.ReadLine());
            char letra = LETTERS[dni % LETTERS.Length];
            Console.WriteLine("Tu dni es {0}{1}", dni, letra);
        }
    }
}
