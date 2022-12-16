using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ejercicio22
{

    class Program

    {
        enum State { On, Off };
         static void Main(string[] args)
         {
            State state = State.Off;

            while (true)
            {
                Console.WriteLine("El estado actual es {0}", state);
                Console.WriteLine("Introduce acción:");
                string input = Console.ReadLine();
                State action = (State)Enum.Parse(typeof(State), input, true);

                if (state == State.On && action == State.Off)
                {
                    state = State.Off;
                }

                else if (state == State.Off && action == State.On)
                {
                    state = State.On;
                }
                else
                {
                    throw new Exception("Acción no válida");
                }
            }



         }
    }
}
