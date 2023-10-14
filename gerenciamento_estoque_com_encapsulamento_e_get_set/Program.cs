using System;

namespace gerenciamento_estoque_com_encapsulamento_e_get_set {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 500.00, 10);

            p.setNome("TELEVISAO");

            p.setNome("T"); //Não muda o para T pois não atende a condição do Set da classe.

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}
