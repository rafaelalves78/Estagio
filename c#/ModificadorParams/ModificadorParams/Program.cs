using System;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });

            Console.WriteLine(result);
        }
    }
}
