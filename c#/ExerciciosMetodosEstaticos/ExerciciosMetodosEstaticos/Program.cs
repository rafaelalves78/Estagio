using System;
using System.Globalization;

namespace ExerciciosMetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorConvertido = ConversorDeMoedas.Conversao(cotacao, quantDolar);

            Console.WriteLine("Valor a ser pago em reais: " + valorConvertido.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
