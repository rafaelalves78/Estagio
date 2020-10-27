using System;

namespace ExerciciosFixacaoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vet = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int alugueis = int.Parse(Console.ReadLine());

            for (int i = 1; i <= alugueis; i++)
            {
                Console.WriteLine($"\nAluguel #{i}:\n");
                Console.Write("Qual o nome do locatário? ");
                string nome = Console.ReadLine();
                Console.Write("\nQual o e-mail do locatário? ");
                string email = Console.ReadLine();
                Console.WriteLine("\nQual o número do quarto que ele deseja alugar? ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();

            Console.WriteLine("Quartos ocupados:\n");

            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + " : " + vet[i]);
                }
            }
        }
    }
}
