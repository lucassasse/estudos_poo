﻿using System;

namespace gerenciamento_estoque {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();
            
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado:");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido:");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + p);
        }
    }
}
