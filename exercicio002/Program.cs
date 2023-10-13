using System;

namespace exercicio002 {
    class Program {
        static void Main(string[] args) {
            Funcionario um = new Funcionario();
            Funcionario dois = new Funcionario();

            Console.WriteLine("Digite o nome e salário do primeiro funcionário:");
            um.nome = Console.ReadLine();
            um.salario = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome e salário do segundo funcionário:");
            dois.nome = Console.ReadLine();
            dois.salario = Double.Parse(Console.ReadLine());

            Double salarioMedio = Math.Round((um.salario + dois.salario) / 2, 2);
            Console.WriteLine("Salário médio = " + salarioMedio.ToString("C"));
        }
    }
}
