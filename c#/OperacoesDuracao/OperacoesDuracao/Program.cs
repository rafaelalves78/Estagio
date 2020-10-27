using System;

namespace OperacoesDuracao
{
    class Program
    {
        static void Main(string[] args)
        {
   
            TimeSpan t1 = TimeSpan.MaxValue;

          
            TimeSpan t2 = TimeSpan.MinValue;

            
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(2, 3, 4, 7, 11);
            Console.WriteLine("\n" + t4 + "\n");

           
            Console.WriteLine("Days: " + t4.Days);
            Console.WriteLine("Hours: " + t4.Hours);
            Console.WriteLine("Minutes: " + t4.Minutes);
            Console.WriteLine("Milliseconds: " + t4.Milliseconds);
            Console.WriteLine("Seconds: " + t4.Seconds);
            Console.WriteLine("Ticks: " + t4.Ticks);

            Console.WriteLine();

           
            Console.WriteLine("TotalDays: " + t4.TotalDays);
            Console.WriteLine("TotalHours: " + t4.TotalHours);
            Console.WriteLine("TotalMinutes: " + t4.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t4.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t4.TotalMilliseconds);



        }
    }
}
