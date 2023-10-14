using System;
using System.Collections.Generic;
using System.Text;

namespace gerenciamento_estoque_com_encapsulamento_e_get_set {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() { }

        public Produto(string nome, double preco) {
            this._nome = nome; //Utilizar this. para casos onde o nome da variável é o mesmo que o nome do parâmetro do construtor, método, etc, para os diferenciar
            this._preco = preco; //Pouco utilizado em C# pois o padrão de nomes já os diferencia
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) { //this - Utiliza o construtor já estruturado, para evitar repetição de código
            _quantidade = quantidade;
        }

        public string GetNome() {
            return _nome;
        }

        public void setNome(string nome) { //Cria uma condição para modificar o atributo da classe, mantendo a regra de negócio e impedindo erros
            if(nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
        }

        public int GetQuantidade() {
            return _quantidade;
        }
    }
}
