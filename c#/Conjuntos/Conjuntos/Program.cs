using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n");

            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nDigite um número inteiro: \n");
            int n = int.Parse(Console.ReadLine());

            if (B.Contains(n))
            {
                Console.WriteLine(n + " pertence ao conjunto B.\n");
            }
            else
            {
                Console.WriteLine(n + " não pertence ao conjunto B.\n");
            }


            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            A.ExceptWith(B);

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            B.Add(8);
            B.Add(7);

           

            Console.WriteLine();

            A.IntersectWith(B);

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }
        }
    }
}
