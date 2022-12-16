using System.Timers;

namespace ejercicio26;

class Program
{
    static void Main()
    {
        int n, result;
        n = LeerNumero();
       

        result = Sumatorio(n);
        Console.WriteLine("El resultado es " + result);

    }
    static int LeerNumero()
    {
        Console.WriteLine("Dame un número");
        return int.Parse(Console.ReadLine());
    }

    static int Sumatorio(int n)
    {
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            result += Productorio(i) + i; // result = result + i
        }

        return result;
        

    }
    static int Productorio(int n)
    {
        int result = 1;

        for (int i = 1; i < n; i++)
        {
            result *= Factorial(i) + i; // result = result * i
        }

        return result;
    }
    static int Factorial(int n)
    {
        int result = 1;

        for (int i = n; i > 1; i--)
        {
            result *= i; // result = result * i
        }

        return result;
    }


}