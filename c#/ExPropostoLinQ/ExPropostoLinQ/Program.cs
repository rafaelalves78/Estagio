using System;
using System.Collections.Generic;
using System.Globalization;
using ExPropostoLinQ.Entities;
using System.IO;
using System.Linq;

namespace ExPropostoLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter with Salary: ");
            double salaryUser = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.WriteLine();

            var emails = list.Where(p => p.Salary > salaryUser).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine($"Email of people whose salary is more than {salaryUser}");
            foreach(string email in emails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine();

            var sumSalary = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.Write("Sum of salary of people whose name starts with 'M': " + sumSalary.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
