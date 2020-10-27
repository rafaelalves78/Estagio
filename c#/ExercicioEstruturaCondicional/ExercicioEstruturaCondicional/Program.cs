using System;
using System.Globalization;

namespace ExercicioEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Insira o salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0.00 && salario <= 2000.00)
            {
                Console.WriteLine("Isento de pagar imposto");
            } else if (salario >= 2000.01 && salario <= 3000.00)
            {

            }
        }
    }
}
