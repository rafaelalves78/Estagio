using System;
using System.Globalization;
using System.Collections.Generic;

namespace Enterprise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> listFunc = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ", CultureInfo.InvariantCulture);
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listFunc.Add(new Employee(id, nome, salario));

                Console.WriteLine("\n");
            }

            char resposta = 'S';

            while (resposta == 'S')
            {
                Console.Write("\nEntre com o ID do funcionário que você irá incrementar o salário: ");
                int buscaId = int.Parse(Console.ReadLine());

                Employee func = listFunc.Find(x => x.Id == buscaId);

                if (func != null)
                {
                    Console.Write("Qual a porcentagem de aumento? ");
                    double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    func.AumentoSalario(porcent);

                    Console.WriteLine("Deseja continuar ajustando o salário dos funcionários?\n");
                    Console.WriteLine("Digite S - Sim ou N - Não! \n");
                    resposta = char.Parse(Console.ReadLine());

                }
                else if (func == null)
                {
                    Console.WriteLine("Id digitado não existe!\n");
                }

                

            }

            Console.WriteLine("Lista de funcionários atualizada:\n");
            foreach (Employee obj in listFunc)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\n");

        }
    }
}
