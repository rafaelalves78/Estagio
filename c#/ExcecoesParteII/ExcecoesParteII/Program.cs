using System;

namespace ExcecoesParteII
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um número inteiro: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite outro número inteiro: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.Write($"\nA divisão de {n1} por {n2} é: ");

                Console.WriteLine();
            }
            catch (DivideByZeroException)
            {
             
                Console.WriteLine("\nError! Division by zero is not allowed!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nFormat Error! " + e.Message);
            }
        }
    }
}
