using System;
using System.Globalization;

namespace Properties
{
    class Produto
    {
      
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
        }

       
        public string Nome
        {
            get { return this._nome; }
            set {
                
                if (value != null && value.Length > 1)
                {
                    this._nome = value;
                }
            }
        }

        public double Preco
        {
            get { return this._preco; }
        }

        public int Quantidade
        {
            get { return this._quantidade; }
        }

        public double ValorTotalEmEstoque()
        {
            return this._preco * this._quantidade;
        }

       
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

     
        public override string ToString()
        {
           
            return this._nome + ", $ " + this._preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + this._quantidade + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
