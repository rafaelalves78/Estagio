using System;

namespace OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            a += 2;

            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

           
            int b = a++;

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = 10;
            int d = ++c;

            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
