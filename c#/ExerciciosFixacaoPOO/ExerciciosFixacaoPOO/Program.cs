using System;
using System.Globalization;

namespace ExerciciosFixacaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Aluno aluno1 = new Aluno();

            Console.WriteLine("Nome do aluno: ");
            aluno1.Nome = Console.ReadLine();

            Console.WriteLine("Nota 1: ");
            aluno1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota 2: ");
            aluno1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota 3: ");
            aluno1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final: " + aluno1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno1.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + aluno1.PontosRestantes().ToString("F2", CultureInfo.InvariantCulture) 
                    + " pontos.");
            }


        }
    }
}
