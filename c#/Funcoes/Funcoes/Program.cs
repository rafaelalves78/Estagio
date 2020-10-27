using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("O maior número é " + resultado);

          
        }

        static int Maior(int a, int b, int c)
        {
            int m = 0;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;

        }
    }
}
