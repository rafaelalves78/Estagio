using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine("Nome: " + p.Nome);
            Console.WriteLine("Preço: " + p.Preco);
            Console.WriteLine("Quantidade: " + p.Quantidade);
        }
    }
}
