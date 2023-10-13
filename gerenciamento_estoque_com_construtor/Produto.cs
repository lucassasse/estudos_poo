using System.Globalization;

namespace gerenciamento_estoque {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) { //Construtor rececendo todos os argumentos/parâmsetros utilizados pela classe
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) { //Construtor com apenas 2 argumentos/parâmetros de entrada
            Nome = nome;
            Preco = preco;
            Quantidade = 10; //Opcional
        }

        public Produto() { } //Declara explicitamente o construtor padrão (que recebe null, 0 e 0.0 por padrão), para poder ser utilizado pelo programa

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
