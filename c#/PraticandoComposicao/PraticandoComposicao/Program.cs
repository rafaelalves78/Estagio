using PraticandoComposicao.Entities;
using PraticandoComposicao.Entities.Enums;
using System;
using System.Globalization;

namespace PraticandoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: \n");
            string nameDept = Console.ReadLine();

            Console.WriteLine("Enter worker data:\n");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           
            Department dept = new Department(nameDept);

            
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("\nHow many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:\n");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.addContract(contract);

            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string yearAndMonth = Console.ReadLine();

            int month = int.Parse(yearAndMonth.Substring(0, 2));
            int year = int.Parse(yearAndMonth.Substring(3));

            Console.Write("\nName: " + worker.Name);
            Console.Write("\nDepartment: " + dept.Name);
            Console.Write("\nIncome for " + yearAndMonth + ": "
                + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
