/*using System;
using System.Globalization;

namespace ejercicio18
{
    internal class Program
    {

        static void Main(string[]args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Introduce la cantidad de numeros");

            int size = PedirNumeroEntero();

            double suma = 0;


            for (int i = 0; i < size; i++)
            {
                double number = PedirNumeroConDecimales();
                suma += number * number;
            }

            double resultado = Math.Sqrt(suma / size);


                static double PedirNumeroEntero {

            

            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduce {num} numeros");
            double numIntroducido;
            double cuadrado = 0;
            double resultado = 0;

            for (int i = 0; i < num; i++)
            {
                numIntroducido = int.Parse(Console.ReadLine());
                cuadrado += numIntroducido * numIntroducido;

            }
            resultado = Math.Sqrt(cuadrado / num);
            Console.WriteLine($" La media cuadratica es : {resultado}");

        }
    }
}*/

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio18
{

    class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            Console.Write("Introduce la cantidad de números: ");

            int size = PedirNumeroEntero();

            double suma = 0;

            for (int i = 0; i < size; i++)
            {
                double number = PedirNumeroConDecimales();
                suma += number * number;
            }
            double resultado = Math.Sqrt(suma / size);
            Console.WriteLine(resultado);
        }

        static int PedirNumeroEntero()
        {
            int resultado = -1;


            do
            {
                try
                {
                    resultado = (int)uint.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("No me jodas, repite");
                }
            }
            while (resultado == -1);
            return resultado;
        }
        static double PedirNumeroConDecimales()
        {
            double resultado = -1;

            do
            {
                try
                {
                    resultado = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("No me jodas, repite");
                }
            }
            while (resultado == -1);
            return resultado;
        }
    }
}
