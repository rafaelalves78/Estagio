using System;
using System.Globalization;

namespace VetoresParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            //declarando e instanciando um vetor
            double[] vet = new double[n];

            double soma = 0.0;

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nDigite a altura\n");
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vet[i];
            }

            double media = soma / n;


            Console.WriteLine("\nMédia das alturas: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
