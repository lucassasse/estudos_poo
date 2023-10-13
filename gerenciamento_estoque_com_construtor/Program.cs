using System;

namespace gerenciamento_estoque {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            //É possível utilizar o construtor padrão, pois isso foi declarado explicitamenta na classe
            Produto p1 = new Produto();

            //Inicia o objeto já utilizando os valores, de acordo com o construtor definido na classe
            Produto p2 = new Produto(nome, preco);

            //Sintaxe alternativa para iniciar a classe já com valores, mesmo sem ter definido construtores na classe
            //Deve possuir o construtor padrão declarado na classe
            Produto p3 = new Produto {
                Nome = "TV",
                Preco = 900.0,
                Quantidade = 20
            };

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
