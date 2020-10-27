using System;
using System.Globalization;

namespace ExercicioEntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo");
            string nome = Console.ReadLine();

            Console.WriteLine("Quanto quartos tem na sua casa?");
            int quantQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura na mesma linha:");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Seu nome completo é: {0} e na sua casa tem {1} quartos", nome, quantQuartos);
            Console.WriteLine("O preço do produto foi: " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
