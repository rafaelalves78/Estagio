using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {

            Nullable<double> x = null;


            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);


            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X é null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine("Y é null");
            }
        }
    }
}
