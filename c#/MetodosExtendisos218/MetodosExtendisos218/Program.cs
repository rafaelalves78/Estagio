using System;
using MetodosExtendisos218.Extensions;

namespace MetodosExtendisos218
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 06, 10, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

        }
    }
}
