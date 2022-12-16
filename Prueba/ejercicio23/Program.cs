using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio23
{

    class Program

    {


        public static void Main(string[] args)
        {

            Console.WriteLine("Le voy a hacer una división, introduzca el primer número");

            double numerador, denominador, total;

            numerador = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo número");

            denominador = Convert.ToDouble(Console.ReadLine());

            total = numerador / denominador;

            try
            {
                if (denominador == 0)
                {
                    throw new Exception("Error división por cero");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Se ha generado un error {0}", e);
            }
            
            Console.WriteLine("EL resultado de la division es " + total);
        }
    }
}