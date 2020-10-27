using System;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo x:");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area de X igual a " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y igual a " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("A maior área é do triângulo X");
            }
            else
            {
                Console.WriteLine("A maior área é do triângulo Y");
            }

        }
    }
}
