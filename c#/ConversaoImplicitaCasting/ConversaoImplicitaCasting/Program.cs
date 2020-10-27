using System;

namespace ConversaoImplicitaCasting
{
    class Program
    {
        static void Main(string[] args)
        {
           
            float x = 4.5f;
            double y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            double a = 5.1;
            float b;

          
            b = (float) a;

            Console.WriteLine(b);

            double c = 6.1;
            int d;
            d = (int)c;

            Console.WriteLine(c);
            Console.WriteLine(d);

            int e = 5;
            int f = 2;
            double resultado = (double) e / f;

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(resultado);
        }
    }
}
