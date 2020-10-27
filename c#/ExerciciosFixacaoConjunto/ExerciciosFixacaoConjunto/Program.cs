using System;
using System.Collections.Generic;

namespace ExerciciosFixacaoConjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int> ();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.WriteLine("Quantos elementos há no conjunto A?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite os códigos dos alunos do curso A: ");

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.WriteLine();

            Console.WriteLine("Quantos elementos há no conjunto B?");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite os códigos dos alunos do curso B: ");

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.WriteLine();

            Console.WriteLine("Quantos elementos há no conjunto C? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite os códigos dos alunos do curso B: ");

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            Console.WriteLine();

            HashSet<int> Total = new HashSet<int> ();

            Total.UnionWith(A);
            Total.UnionWith(B);
            Total.UnionWith(C);

            Console.WriteLine("O total de alunos é: " + Total.Count);
            Console.WriteLine();
        }
    }
}
