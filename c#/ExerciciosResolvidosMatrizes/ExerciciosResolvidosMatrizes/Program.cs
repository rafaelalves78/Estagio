using System;
using System.Globalization;

namespace ExerciciosResolvidosMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

          
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite os valores da linha {i}: ");

             
                string[] values = Console.ReadLine().Split(' ');

                
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            Console.WriteLine("\n");

            Console.Write("Main diagonal: ");

          
            for(int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }

            Console.WriteLine("\n");

            int count = 0;

         
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
