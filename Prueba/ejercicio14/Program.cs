namespace practica14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la semilla");
            int seed = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la cantidad de caracteres");
            int length = int.Parse(Console.ReadLine());//

            Random random = new Random(seed);// es para la semilla al azar 
            for (int i = 0; i < length; i++)
            {
                int ascii = random.Next(256);
                Console.Write((char)ascii);
            }
            Console.WriteLine();
        }
    }
}

