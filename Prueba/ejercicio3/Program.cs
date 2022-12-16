class hola
{
    static void Main()
    {
        Console.WriteLine("Introduce los grados Farenheit");
        double grados = Convert.ToInt32(Console.ReadLine()), final;
        final = (((grados - 32) / 9) * 5);
        Console.WriteLine("Hace " + final + "grados Celsius");
    }
}