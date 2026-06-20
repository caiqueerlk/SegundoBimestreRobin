using System;
using System.Collections.Generic;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            double valorTotal = 0;

            for (int i = 0; i < 4; i++)
            {
                Produto produto = new Produto();

                Console.Write("Produto: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Preço: ");
                produto.Preco = double.Parse(Console.ReadLine());

                produtos.Add(produto);
                valorTotal += produto.Preco;

                Console.WriteLine();
            }

            Console.WriteLine("Produtos cadastrados:");

            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"{produto.Nome} - R$ {produto.Preco:F2}");
            }

            Console.WriteLine();
            Console.WriteLine($"Valor total: R$ {valorTotal:F2}");
        }
    }
}