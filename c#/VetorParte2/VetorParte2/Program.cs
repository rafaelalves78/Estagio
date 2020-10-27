using System;
using System.Globalization;

namespace VetorParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos você quer cadastrar?\n");
            int num = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[num];

            double soma = 0.0;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\nQual o nome do produto?\n");
                string nome = Console.ReadLine();
                Console.WriteLine("\nQual o preço do produto?\n");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produtos[i] = new Produto { Nome = nome, Preco = preco };

                soma += produtos[i].Preco;
            }

            double media = soma / num;

            Console.WriteLine("\nMédia dos preços dos produtos: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
