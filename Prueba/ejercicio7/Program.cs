/*using System.Net.NetworkInformation;

class hola
{
    static void Main()
    {
        int LADO1, LADO2, LADO3;
        string linea;
        Console.Write("DIGITE LADO 1 :"); linea = Console.ReadLine();
        LADO1 = int.Parse(linea);
        Console.Write("DIGITE LADO 2 :"); linea = Console.ReadLine();
        LADO2 = int.Parse(linea);
        Console.Write("DIGITE LADO 3 :"); linea = Console.ReadLine();
        LADO3 = int.Parse(linea);


        if ((LADO1 == LADO2) & (LADO2 == LADO3))
        {
            Console.WriteLine("TRIÁNGULO EQUILÁTERO. TODOS IGUALES");
        }
        else
        {
            if ((LADO1 != LADO2) & (LADO1 != LADO3) & (LADO2 != LADO3))
            {
                Console.WriteLine("TRIÁNGULO ESCALENO. NINGUNO IGUAL");
            }
            else
            {
                Console.WriteLine("TRIÁNGULO ISÓSCELES. DOS IGUALES");
            }
        }
        Console.Write("Pulse una Tecla:"); Console.ReadLine();
    }

}
*/

Console.WriteLine("introduce los 3 lados del triangulo");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a == b && b == c) //comprueba si a es igual a b y si b es igual b a c
{
    Console.WriteLine("triangulo equilatero todos los lados son iguales");
}
else if (a != b && a != c && b != c) //comprueba si a y b son distintos a y c distintos y b y c distiontos
{
    Console.WriteLine("triangulo escaleno ninguno igual");
}
else
{
    Console.WriteLine("triangulo isosceles");
}
Console.ReadLine();