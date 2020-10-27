using System;
using System.Globalization;

namespace SegundoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Maria";
            char genero = 'F';
            int idade = 35;
            double saldo = 10.56789;

            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
       
            Console.WriteLine(saldo.ToString("F2"));
        
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
