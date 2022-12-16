using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio21
{

    class Program

    {

        enum DaysOfWeek {Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        public static void Main(string[] args)
        {
            Console.WriteLine("introduzca un día de la semana: ");
            string dia = Console.ReadLine();

            DaysOfWeek introducido = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), dia, true);

            switch (introducido)
            {
                case DaysOfWeek.Saturday:
                case DaysOfWeek.Sunday:
                    Console.WriteLine("no laboral");
                    break;

                default:
                    Console.WriteLine("Laboral");
                    break;

            }

        }

    }
}
