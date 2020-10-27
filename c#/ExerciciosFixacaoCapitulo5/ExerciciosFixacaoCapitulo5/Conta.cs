using System;
using System.Globalization;

namespace ExerciciosFixacaoCapitulo5
{
    class Conta
    {
        private string _titularConta;
        public int NumeroConta { get; private set; }
        public double Saldo { get; set; }

        public Conta(string nome, int conta)
        {
            this._titularConta = nome;
            this.NumeroConta = conta;
        }

        public Conta(string nome, int conta, double saldo) : this(nome, conta)
        {
            this.Saldo = saldo;
        }

        public string TitularConta
        {
            get
            {
                return this._titularConta;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    this._titularConta = value;
                }
            }
        }

        public void Deposito(double quantia)
        {
            this.Saldo = Saldo + quantia;
        }

        public void Saque(double quantia)
        {
            this.Saldo = (Saldo - quantia) - 5;
        }

        public override string ToString()
        {
            return "Conta: " + this.NumeroConta
                + "\nTitular: " + this._titularConta 
                + "\nSaldo: " + this.Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
