using System;
using System.Globalization;

namespace ExerciciosEstruturasSequenciais
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite um valor a: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite um valor b: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite um valor c: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaTriangulo = (double)(a*c) / 2;

            double pi = 3.14159;
            double areaCirculo = (double) pi * (Math.Pow(c, 2));

            double areaTrapezio = (double) ((a + b) * c) / 2;

            double areaQuadrado = (double) Math.Pow(b, 2);

            double areaRetangulo = (double) a * b;

            Console.WriteLine("A área do triângulo que tem base " + a.ToString(CultureInfo.InvariantCulture) + " e altura " + c.ToString(CultureInfo.InvariantCulture) + " é igual a " 
                + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("A área do círculo que tem raio igual a " + c.ToString(CultureInfo.InvariantCulture) +
                " é " + areaCirculo.ToString("F3",CultureInfo.InvariantCulture));

            Console.WriteLine("A área do Trapézio que tem base 1 igual a " + a.ToString(CultureInfo.InvariantCulture) 
                + " e base 2 igual a " + b.ToString(CultureInfo.InvariantCulture) + " é igual a: " 
                + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("A área do quadrado que tem lado " + b.ToString(CultureInfo.InvariantCulture) + " é igual a: " 
                + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("A área do retângulo de lado 1 " + a.ToString(CultureInfo.InvariantCulture) + " lado 2 " 
                + b.ToString(CultureInfo.InvariantCulture) + " é igual a: " 
                + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}