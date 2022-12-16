// Susing System.Globalization;
using System.Globalization;
using System.Timers;

namespace ejercicio29
{
    class Program
    {
        const double EURO_A_LIBRA = 0.86;
        const double EURO_A_DOLAR = 1.28611;
        const double EURO_A_YEN = 129.852;
        enum Moneda { Libras, Dolares, Yenes };
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Introduce la cantidad de euros: ");
            double euros = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tipo de moneda al que quieres cambiar: ");
            Moneda moneda = (Moneda)Enum.Parse(typeof(Moneda), Console.ReadLine(), true);



            static void Convertir(double euros, string moneda)
            {
                object currency;
                if (Enum.TryParse(typeof(Moneda), moneda, true, out currency))
                {

                    double cambio = 0;

                    switch ((Moneda)currency)
                    {
                        case Moneda.Libras:
                            cambio = euros * EURO_A_LIBRA;
                            break;
                        case Moneda.Dolares:
                            cambio = euros * EURO_A_DOLAR;
                            break;
                        case Moneda.Yenes:
                            cambio = euros * EURO_A_YEN;
                            break;

                    }
                    Console.WriteLine($"{euros} son {cambio} {currency}");
                }
                else
                {
                    Console.WriteLine("No se puede esa moneda");
                }

                //    if (figura == Monedas.Libras)
                //    {
                //        double libras = 0.86;
                //        double result1 = euros * libras;
                //        Console.WriteLine(result1 + " libras");
                //    }
                //    else if (figura == Monedas.Dolares)
                //    {
                //        double dolares = 1.28611;
                //        double result2 = euros * dolares;
                //        Console.WriteLine(result2 + " dolares");
                //    }
                //    else
                //    {
                //        double yenes = 129.852;
                //        double result3 = euros * yenes;
                //        Console.WriteLine(result3 + " yenes");
                //    }
                //}



            }

        }
    }
}







