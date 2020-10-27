using System;
using System.Globalization;

namespace PrimeirosExerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Funcionarios F1, F2;

            F1 = new Funcionarios();
            F2 = new Funcionarios();

            Console.WriteLine("Qual o nome do funcionario?");
            F1.Nome = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Qual o salário de " + F1.Nome);
            F1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual o nome do funcionario?");
            F2.Nome = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Qual o salário de " + F2.Nome);
            F2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (double)(F1.Salario + F2.Salario) / 2.00;

            Console.WriteLine("A média salarial é de: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
