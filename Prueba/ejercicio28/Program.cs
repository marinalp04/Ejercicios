using System.Formats.Asn1;
using System.Globalization;
using System.Timers;

namespace ejercicio28
{
    class Program
    {

        enum Figuras { Circulo, Cuadrado, Triangulo };
        static void Main()
        {
            Console.WriteLine("Introduce la figura de la que quieras calcular el área (circulo, triangulo, cuadrado): ");
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Figuras figura = (Figuras)Enum.Parse(typeof(Figuras), Console.ReadLine(), true);

            double area = 0;
            switch (figura)
            {
                case Figuras.Circulo:
                    area = Circulo();
                    break;
                case Figuras.Cuadrado:
                    area = Cuadrado();
                    break;
                case Figuras.Triangulo:
                    area = Triangulo();
                    break;

            }
            Console.WriteLine("El area es {0}" + area);

            //        if (figura == Figuras.Circulo)
            //        {
            //            Console.WriteLine("Introduce el radio:");
            //            double radio = double.Parse(Console.ReadLine());

            //            double result1 = Circulo(radio);
            //            Console.WriteLine("El área del círculo es: " + result1);
            //        }
            //        else if (figura == Figuras.Triangulo)
            //        {
            //            Console.WriteLine("Introduce la base:");
            //            double @base = double.Parse(Console.ReadLine());
            //            Console.WriteLine("Introduce la altura:");
            //            double altura = double.Parse(Console.ReadLine());
            //            double result2 = Triangulo(@base, altura);
            //            Console.WriteLine("El área del triángulo es: " + result2);
            //        }
            //        else 
            //        {
            //            Console.WriteLine("Introduce el lado:");
            //            double lado = double.Parse(Console.ReadLine());
            //            double result3 = Cuadrado(lado);
            //            Console.WriteLine("El área del cuadrado es: " + result3);
            //        }
            //    }
        }

            static double Circulo()
            {

                Console.WriteLine("Introduce el radio:");
                double radio = double.Parse(Console.ReadLine());

                return (radio * radio) * Math.PI;


            }

            static double Triangulo()
            {


                Console.WriteLine("Introduce la base:");
                double @base = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduce la altura:");
                double altura = double.Parse(Console.ReadLine());


                return (@base * altura) / 2;
            }
            static double Cuadrado()
            {
                Console.WriteLine("Introduce el lado:");
                double lado = double.Parse(Console.ReadLine());
                return lado * lado;

            }

        





    }
}
