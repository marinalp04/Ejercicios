using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio20
{

    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("introduzca un número del 1 al 12: ");
            int number = int.Parse(Console.ReadLine());

            Month introducido = (Month)number;

            Console.WriteLine(introducido);


        }
            enum Month
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12

        }
    
    }
}