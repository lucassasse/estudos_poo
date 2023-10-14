using System;
using System.Collections.Generic;
using System.Text;

namespace gerenciamento_estoque_com_construtor_properties {
    class Produto {
        private string _nome;
        public double Preco { get; private set; } //Auto Properties - Caso não haja implementação especial (como no Nome)
        public int Quantidade { get; private set; } //Posso utilizar desta forma, resumindo o código

        public Produto() { }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome { //value = valor recebido via parâmetro
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        //Orderm de implementação de membros de classe:
        //-Atributos privados
        //-Atibutos autoimplementados
        //-Construtores
        //-Propriedades customizadas
        //-Outros métodos da classe
    }
}
