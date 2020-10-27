using System;
using System.Globalization;

namespace ExerciciosFixacaoCapitulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine(); 
            Console.Write("Haverá depósito inicial? (s/n): ");
            char resposta = char.Parse(Console.ReadLine());

            if(resposta == 's' || resposta == 'S')
            {
                Console.Write("Qual o valor do depósito? ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c = new Conta(nome, conta, saldo);
            }
            else
            {
                c = new Conta(nome, conta, 0.0);
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Dados Conta:");
            Console.WriteLine(c);
            Console.WriteLine("-------------------------------------");

            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c.Deposito(quantia);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(c);
            Console.WriteLine("--------------------------------------");

            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c.Saque(quantia);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);
            Console.WriteLine("---------------------------------------");



        }
    }
}
