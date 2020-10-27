using System;
using System.Globalization;

namespace CondicionalTernária
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20) ? preco * 0.1: preco * 0.5;
            Console.WriteLine("Desconto: " + desconto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço total: " + (preco-desconto).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
