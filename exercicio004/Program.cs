using System;

namespace exercicio_004 {
    class Program {
        static void Main(string[] args) {
            Funcionario func = new Funcionario();
            
            Console.WriteLine("Entre com os dados do funcionário:");

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Impostos: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine();
            Console.Write("Digite a porcentagem do aumento salarial: ");
            double aumento = double.Parse(Console.ReadLine());
            func.AumentarSalario(aumento);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do Funcionário: " + func);

        }
    }
}
