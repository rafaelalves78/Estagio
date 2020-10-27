using System;

namespace Duracao
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            Console.WriteLine();

            TimeSpan t2 = new TimeSpan();
            Console.WriteLine(t2);

            Console.WriteLine();

            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);

            Console.WriteLine();

            TimeSpan t4 = new TimeSpan(1 , 2, 11, 21);
            Console.WriteLine(t4);

            Console.WriteLine();

            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t5);

        }
    }
}
