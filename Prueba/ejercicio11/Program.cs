

namespace ejercicio11
{
    class Program
    {
        static void Main()
        {


            Console.WriteLine("introduzca un número: ");
            int num = int.Parse(Console.ReadLine());


            for (int i = 2; i <= num; i++) //el 1 no es primo
            {
                bool isPrime = true;

                //Comprobamos desde el 2 hasta i / 2 ya que entre 1 siempre va a ser disible
                //  como maxima un número se va a poder dividir entre su mitad

                for (int j = 2; j <= i / 2 && isPrime; j++)
                {
                    if (i % j == 0) isPrime = false;

                }
                if (isPrime) Console.WriteLine(i);
            }
        }
    }
}
            