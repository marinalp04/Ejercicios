﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq.Expressions;

namespace Ejercicio24
{

    class Program

    {
        enum State { Idle, Playing, Paused, Stopped, Closed };
        static void Main()
        {
            State state = State.Idle;
            char input;

            Console.WriteLine($"Estado actual: {state}");

            while (state != State.Closed)
            {
                try
                {
                    input = Console.ReadLine()[0];

                    switch (input)
                    {
                        case 'p':
                            if (state == State.Idle || state == State.Paused) state = State.Playing;
                            else if (state == State.Playing) state = State.Paused;
                            else throw new Exception("Acción no disponible");
                            break;

                        case 's':
                            if (state == State.Playing || state == State.Paused) state = State.Stopped;
                            else throw new Exception("Acción no disponible");
                            break;

                        case 'q':
                            state = State.Closed;
                            break;

                        default: throw new Exception("Acción no disponible");
                    }
                    Console.WriteLine($"Estado actual : {state}");

                }
                catch(Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }

            }




        }
    }
}
