Console.WriteLine("introduce un numero entero");
int num = Convert.ToInt32(Console.ReadLine());
int decenas, unidades, numerofinal;
decenas = num / 10;
unidades = num % 10;
numerofinal = (unidades * 10) + decenas;
Console.WriteLine(numerofinal);
Console.ReadLine();
