/*using System.Runtime.CompilerServices;

Console.WriteLine("Introduce un numero");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Introduce {num} numeros");
int numIntroducido = int.Parse(Console.ReadLine());
double media = 0;


for (int i = 0; i < num; i++)
{
    numIntroducido = int.Parse(Console.ReadLine());
    media += numIntroducido ;

}
media = (media / num);
Console.WriteLine($" La media cuadratica es : {media}");*/


Console.WriteLine("Introduce un numero");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Introduce {num} numeros");
double numIntroducido;
double media = 0;

for (int i = 0; i < num; i++)
{
    numIntroducido = int.Parse(Console.ReadLine());
    media += numIntroducido;
}

Console.WriteLine($"La media de los numeros es: {media / num}");

