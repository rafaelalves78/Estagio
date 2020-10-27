﻿using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("T");

            Console.WriteLine("Nome: " + p.GetNome());
            Console.WriteLine("Preço: " + p.GetPreco());
            Console.WriteLine("Quantidade: " + p.GetQuantidade());
        }
    }
}
