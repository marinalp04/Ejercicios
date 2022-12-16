class hola
{
    static void Main()
    {
        Console.WriteLine("Introduce un número entero");
        int num = Convert.ToInt32(Console.ReadLine()), fin;
        fin = num % 10;
        Console.WriteLine(fin);
    }
}