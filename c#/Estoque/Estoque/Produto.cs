using System;
using System.Globalization;

namespace Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            this.Quantidade = 10;
        }


        public Produto (string nome, double preco) : this()
        {
            this.Nome = nome;
            this.Preco = preco;
        }


        public Produto (string nome, double preco, int quantidade) : this(nome, preco)
        {

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
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quantidade + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
