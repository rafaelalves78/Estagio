using System;
using System.Globalization;

namespace ExerciciosFixacaoPOO
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return this.SalarioBruto - this.Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            this.SalarioBruto = this.SalarioBruto + (this.SalarioBruto * (porcentagem/100.0));
        }

        public override string ToString()
        {
            return "Funcionário: " + this.Nome + ", R$ " + this.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
