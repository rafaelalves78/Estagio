using System;
using System.Globalization;

namespace AutoProperties
{
    class Produto
    {
       
        public string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public string Nome
        {
            get { return this._nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    this._nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return this.Preco * this.Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        

        public override string ToString()
        {
            return this._nome + ", $ " + this.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + this.Quantidade + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
