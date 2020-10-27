using System;

namespace DataHoraFormatacao
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2020, 4, 10, 19, 44, 58);

            Console.WriteLine(d.ToLongDateString() + "\n");

            string s2 = d.ToLongTimeString();

            Console.WriteLine(s2 + "\n");

            string s3 = d.ToShortDateString();
            Console.WriteLine(s3 + "\n");

            string s4 = d.ToShortTimeString();
            Console.WriteLine(s4 + "\n");

            string s5 = d.ToString();
            Console.WriteLine(s5 + "\n");

            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6 + "\n");

            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s7 + "\n");
        }
    }
}
