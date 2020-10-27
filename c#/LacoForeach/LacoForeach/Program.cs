using System;

namespace LacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "José", "Bob" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("----------------------------------------------");

            

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
