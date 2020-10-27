using System;
using System.Collections.Generic;
using System.Globalization;

namespace Enterprise
{
    class Employee
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public double Salario { get; set; }

        public Employee(int id, string nome, double salario)
        {
            this.Id = id;
            this.Nome = nome;
            this.Salario = salario;
        }

        public void AumentoSalario(double porcent)
        {
            Salario += Salario*(porcent / 100.0);
        }

        public override string ToString()
        {
            return this.Id + " , " + this.Nome + ", " + this.Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
