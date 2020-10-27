using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar?");
            int n = int.Parse(Console.ReadLine());

            int i = 0;

            int soma = 0;

            for (i = 1; i <= n; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine($"Valor #{i}");
                soma = soma + valor;
            }

            Console.WriteLine($"Soma é igual a {soma}");

        }
    }
}
