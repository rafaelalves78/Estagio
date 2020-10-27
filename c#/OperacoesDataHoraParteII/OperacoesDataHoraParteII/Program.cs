using System;

namespace OperacoesDataHoraParteII
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2020, 4, 10, 19, 55, 58);
            Console.WriteLine(d + "\n");

          
            DateTime d2 = d.AddHours(2);
            Console.WriteLine(d2 + "\n");

           
            DateTime d3 = d.AddMinutes(3);

            Console.WriteLine(d);

            Console.WriteLine(d3 + "\n");

            
            DateTime d4 = new DateTime(2000, 10, 15);
            DateTime d5 = new DateTime(2000, 10, 18);

            
            TimeSpan t = d5.Subtract(d4);

            Console.WriteLine(t + "\n");

        }
    }
}
