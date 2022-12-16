namespace apuntes;

/*class Program
{
     

    enum DayOfWeek { Monday = 1, Wednesday = 3, Saturday = 6 };//el numerador tiene que estar dentro de una clase

    
    public static void Main()
    {
        DayOfWeek dayOfWeek = DayOfWeek.Saturday;

        Console.WriteLine((int)dayOfWeek);
        Console.WriteLine((DayOfWeek)3);
    }

    
}*/

/*class Program
{

   const int TIRADAS = 50;
   static readonly double CONSTANTE_COMPLEJA = Math.Cos(4);
   static readonly DateTime NOW = DateTime.Now;

   public static void Main()
   {
       for (int i= 0; i < TIRADAS; i++)
       {
           Console.WriteLine(i);
       }



   }


}*/

class Program
{

    public static void Main()
    {
        
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        if (number1 == 0)
            throw new Exception("el denominador no puede ser 0");
        else
            Console.WriteLine(number1 / number2);
    }


}