using System;
using System.Globalization;

namespace ExerciciosPropostosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EX1) Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso.

            Console.WriteLine("Digite um valor inteiro entre 1 e 1000");
            int valor = int.Parse(Console.ReadLine());

            while(valor <= 1 && valor >= 1000)
            {
                Console.WriteLine("Digite um valor inteiro (sem vírgula) entre 1 e 1000");
                valor = int.Parse(Console.ReadLine());
            }

            for(int i = 1; i <= valor; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            } */

            /*EX2) Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            Console.WriteLine("Quantas números inteiros você quer digitar?");
            int n = int.Parse(Console.ReadLine());

            int valor = 0;
            int count_in = 0;
            int count_out = 0;

            Console.WriteLine("Digite " + n + " numeros inteiros: ");

            for (int i = 1; i<= n; i++)
            {
             
                valor = int.Parse(Console.ReadLine());
            
                if (valor >= 10 && valor <= 20)
                {
                    count_in++;
                }
                else
                {
                    count_out++;
                }

            }

            Console.WriteLine($"{count_in} in");
            Console.WriteLine($"{count_out} out"); */

            /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
peso 5.
*/

            /*EX3) Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
peso 5.

            Console.WriteLine("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------------");

            double real1 = 0.0;
            double real2 = 0.0;
            double real3 = 0.0;

            double mediaPonderada = 0.0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Digite 3 números reais na mesma linha: ");
                string[] vet = Console.ReadLine().Split(' ');

                Console.WriteLine("------------------------------------------------------------");

                real1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                real2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                real3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                Console.WriteLine($"Numeros digitados: {real1} {real2} {real3}");

                Console.WriteLine("------------------------------------------------------------");

                Console.WriteLine("Digite os pesos de cada valor digitado: ");

                int peso1 = int.Parse(Console.ReadLine());
                int peso2 = int.Parse(Console.ReadLine());
                int peso3 = int.Parse(Console.ReadLine());

                mediaPonderada = ((peso1 * real1) + (peso2 * real2) + (peso3 * real3)) / (peso1 + peso2 + peso3);

                Console.WriteLine("--------------------------------------------------------------");

                Console.WriteLine("A média ponderada dos valores digitados é: " + mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));

                Console.WriteLine("_______________________________________________________________"); 

        } */

            /*EX4) Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
             * 
             * Console.WriteLine("Digite um número inteiro N:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            double divisao = 0;

            for ( int i = 1; i <= numero ; i = i + 1 )

            {
                Console.WriteLine($"Digite dois pares de números na mesma linha {numero} vezes:");
                string[] vet = Console.ReadLine().Split(' ');

                Console.WriteLine("");

                int num1 = int.Parse(vet[0], CultureInfo.InvariantCulture);
                int num2 = int.Parse(vet[1], CultureInfo.InvariantCulture);

                if (num2 == 0)
                {
                    Console.WriteLine("Divisão Impossível!");

                    Console.WriteLine("");
                }
                else
                {
                    divisao = (double) num1 / num2;
                    Console.WriteLine("A divisão de " + num1.ToString(CultureInfo.InvariantCulture) + " por " + num2.ToString(CultureInfo.InvariantCulture) 
                        + " é igual a " + divisao.ToString(CultureInfo.InvariantCulture));

                    Console.WriteLine("");
                }
            } */

            /* Terminar de fazer
             * 
             * Console.WriteLine("Digite um número inteiro:");
            double num = double.Parse(Console.ReadLine());

            double somaFat = (double) 0;

            for (int i  = 1; i <= num; i++)
            {

                double fatorial = (double) (num * (num - 1));

                num--;

                somaFat = somaFat + fatorial;
            }

            Console.WriteLine("O fatorial de " + num + " é igual a " + somaFat);*/

            /*Ex6) Ler um número inteiro N e calcular todos os seus divisores.
             * 
             * Console.WriteLine("Escreve um numero N inteiro:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine($"{i}");
                }
            } */

            /* Ex7) Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
exemplo.

             * 
             * Console.WriteLine("Digite um numero inteiro positivo");
            int numPositivo = int.Parse(Console.ReadLine());

            while (numPositivo < 0)
            {
                Console.WriteLine("Digite um numero válido [inteiro e positivo]:");
                numPositivo = int.Parse(Console.ReadLine());

            }

            for (int i = 1; i <= numPositivo; i++)
            {
                Console.WriteLine("Linha: " + i + " Qudrado da linha: " + Math.Pow(i,2) + " Cubo da linha: " + Math.Pow(i,3));
            } */

        }
    }
}
