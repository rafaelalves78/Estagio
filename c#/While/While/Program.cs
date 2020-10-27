using System;
using System.Globalization;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número:");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0)
            {
                double raiz = Math.Sqrt(x);

                Console.WriteLine("A raiz quadrada do número é: " + raiz.ToString("F3", CultureInfo.InvariantCulture));

                Console.WriteLine("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            Console.WriteLine("Número negativo");
        }
    }
}
