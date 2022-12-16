namespace metodos;

class Program
{
    static void Main()
    {
        int m, n, result;
        m = LeerNumero();
        n = LeerNumero();

        result = Combinatorio(m, n);

    }
    static int LeerNumero()
    {
        Console.WriteLine("Dame un número");
        return int.Parse(Console.ReadLine());
    }

    static int Combinatorio(int a, int b)
    {
        return Factorial(a) / (Factorial(b) * Factorial (a-b)); 
    }

    static int Factorial(int x )
    {
        int result = 1;

        for(int i = x; i > 1; i--)
        {
            result *= i; // result = result * i
        }

        return result;
    }
}

