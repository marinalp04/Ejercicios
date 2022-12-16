using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio36
{

    class Program
    {

        public static void Main(string[] args)

        {
            Console.WriteLine("Introduce una lista de números separados por comas");
            
            string introducido = Console.ReadLine();
            string[] numerosDivididos = introducido.Split(',');

            int[] numerosDeVerdad = new int[numerosDivididos.Length];

            for (int i = 0; i < numerosDeVerdad.Length; i++)
            {
                numerosDeVerdad[i] = int.Parse(numerosDivididos[i]);
            }



            

            int t;
            for (int i = 1; i < numerosDeVerdad.Length; i++)
            {

                for (int j = numerosDeVerdad.Length - 1; j >= i; j--)

                    if ((int)numerosDeVerdad[j - 1] > (int)numerosDeVerdad[j])
                    {
                        t = numerosDeVerdad[j - 1];
                        numerosDeVerdad[j - 1] = numerosDeVerdad[j];
                        numerosDeVerdad[j] = t;
                    }

            }

            Console.Write($"[{String.Join(",", numerosDeVerdad)}]");


        }
    }
}