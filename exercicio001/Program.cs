using System;

namespace exercicio001 {
    class Program {
        static void Main(string[] args) {
            Pessoa um, dois;
            um = new Pessoa();
            dois = new Pessoa();

            Console.WriteLine("Nome e Idade da primeira pessoa:");
            um.nome = Console.ReadLine();
            um.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome e Idade da segunda pessoa:");
            dois.nome = Console.ReadLine();
            dois.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: " + um.nome);
            Console.WriteLine("Idade: " + um.idade);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: " + dois.nome);
            Console.WriteLine("Idade: " + dois.idade);

            if (um.idade > dois.idade) {
                Console.WriteLine("Pessoa mais velha: " + um.nome);
            } else if (um.idade < dois.idade) {
                Console.WriteLine("Pessoa mais velha: " + dois.nome);
            } else {
                Console.WriteLine("As pessoas pussuem a mesma idade!");
            }

        }
    }
}
