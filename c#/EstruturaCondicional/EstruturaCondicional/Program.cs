using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Console.WriteLine("Bom dia");

            if (x > 5)
            {
                Console.WriteLine("Boa tarde");
            }

            Console.WriteLine("Boa noite");

            Console.WriteLine("------------------------------");

            Console.WriteLine("Digite um numero inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar");
            }

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Qual a hora atual?");
            double hora = double.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");

            } else if (hora < 18){
                Console.WriteLine("Boa tarde!");
            } else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
