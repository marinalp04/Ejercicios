namespace ejercicio11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("introduzca un número: ");
            int number = int.Parse(Console.ReadLine());
            Random random = new Random();
              bool match = false;
            for (int i = 0; i < 5; i++)
            {
                int randomNumber = random.Next(1, number + 1);

                Console.WriteLine(randomNumber);

                if (randomNumber == number && !match)
                {
                    Console.WriteLine("Coincide");
                    match = true;
                }
            }
        }
    }
}