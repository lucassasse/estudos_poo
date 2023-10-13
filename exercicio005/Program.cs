using System;

namespace exercicio005 {
    class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2"));

            if (aluno.VerificaAprovacao()) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("NOTA FALTANTE: " + aluno.NotaFaltante());
            }
        }
    }
}
