using System;
using System.Globalization;

namespace SemOrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo x:");

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (xA + xB + xC) / 2.0;
            double pY = (yA + yB + yC) / 2.0;

            double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));
            double areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));

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
