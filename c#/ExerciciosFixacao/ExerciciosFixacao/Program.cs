using System;

namespace ExerciciosFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o número de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("\nDigite os elementos da linha: " + i);
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("\nDigite um número que pertença a matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Posição: " + i + ", " + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
