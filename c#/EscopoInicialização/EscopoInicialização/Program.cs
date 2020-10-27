using System;
using System.Globalization;

namespace EscopoInicialização
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = 0.0;

          
            if (preco > 100)
            {
                desconto = preco * 0.1;

            }

            double total = (double)preco - desconto;

            Console.WriteLine("Você recebeu: " + desconto.ToString("F2", CultureInfo.InvariantCulture) + " reais de desconto.");
            Console.WriteLine("O valor total a pagar é igual a: " + total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
