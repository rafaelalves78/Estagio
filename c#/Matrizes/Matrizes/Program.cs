using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

           
            Console.WriteLine(mat.Length);

            Console.WriteLine("\n");

            
            Console.WriteLine(mat.Rank);

            Console.WriteLine("\n");

           
            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1));
        }
    }
}
