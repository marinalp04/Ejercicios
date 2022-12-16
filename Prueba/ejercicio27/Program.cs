using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq.Expressions;

namespace Ejercicio27
{

    class Program

    {

        static void Main()
        {
            
            Console.WriteLine("Introduzca el primer valor:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo valor:");
            m = int.Parse(Console.ReadLine());

            int result = Fibonacci(a) + Fibonacci(b);


            static int Fibonacci(int x)
            {
                for (int i = 0; i < n1; i++)
                {
                    if (i <= 1)
                    {
                        result = x;


                    else
                        {
                            result = Fibonacci(x - 1) + Fibonacci(x - 2);
                        }
                        return result;
                    }
                }
            }
        }
    }
}

                

               
        
    
