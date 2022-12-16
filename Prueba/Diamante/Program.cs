namespace ejercicio19Diamante
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Introduce un número entero");
            int filas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= filas; i++)
            {
                int spaces = filas - i;

                Console.Write(new String(' ', spaces));

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }

        }
    }
}