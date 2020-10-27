using System;

namespace ExerciciosPropostosWhile
{
    class Program
    {
        static void Main(string[] args)
        {

           


            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Digite o combustível preferido onde 1 = alcool, 2 = gasolina, 3 = diesel e 4 = fim:");
            int combustivel = int.Parse(Console.ReadLine());

            while (combustivel < 1 || combustivel > 4)
            {
                Console.WriteLine("Informe um código válido de 1 a 4:");
                combustivel = int.Parse(Console.ReadLine());

                while (combustivel >= 1 && combustivel <= 4)
                {

                    if (combustivel == 1)
                    {
                        alcool++;
                    }
                    else if (combustivel == 2)
                    {
                        gasolina++;
                    }
                    else if (combustivel == 3)
                    {
                        diesel++;
                    } else
                    {
                        break;
                    }

                    Console.WriteLine("Digite o combustível preferido onde 1 = alcool, 2 = gasolina, 3 = diesel e 4 = fim:");
                    combustivel = int.Parse(Console.ReadLine());

                }

            }

            Console.WriteLine("Muito Obrigada!");
            Console.WriteLine("Alcool = " + alcool);
            Console.WriteLine("Gasolina = " + gasolina);
            Console.WriteLine("Diesel = " + diesel);

        }
    }
}

