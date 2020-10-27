using System;
using System.Collections.Generic;

namespace CursosAlunosConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            int codigoAluno = 0;

            Console.Write("Quantos alunos deseja cadastrar no curso A? ");
            int quantA = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quantA; i++)
            {
                Console.WriteLine($"Qual o código do aluno {i}?");
                codigoAluno = int.Parse(Console.ReadLine());
                courseA.Add(codigoAluno);
            }

            Console.Write("Quantos alunos deseja cadastrar no curso B? ");
            quantA = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quantA; i++)
            {
                Console.WriteLine($"Qual o código do aluno {i}?");
                codigoAluno = int.Parse(Console.ReadLine());
                courseB.Add(codigoAluno);
            }

            Console.Write("Quantos alunos deseja cadastrar no curso C? ");
            quantA = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quantA; i++)
            {
                Console.WriteLine($"Qual o código do aluno {i}?");
                codigoAluno = int.Parse(Console.ReadLine());
                courseC.Add(codigoAluno);
            }

            HashSet<int> union = new HashSet<int>(courseA);
            union.UnionWith(courseB);
            union.UnionWith(courseC);

            Console.WriteLine("Total alunos: " + union.Count);
        }
    }
}
