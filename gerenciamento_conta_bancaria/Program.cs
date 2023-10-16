using System;

namespace gerenciamento_conta_bancaria {
    class Program {
        static void Main(string[] args) {
            Conta conta;

            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            
            Console.Write("Entre com o titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string haveraDepositoInicial = Console.ReadLine();

            if(haveraDepositoInicial == "s" || haveraDepositoInicial == "S") {
                Console.Write("Entre com o valor do depósito inicial: ");
                double valorDepositoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(numeroConta, nomeTitular, valorDepositoInicial);
            } else {
                conta = new Conta(numeroConta, nomeTitular);
            }
            Console.WriteLine("Dados da Conta: " + conta);
            
            Console.Write("Entre com o valor para depósito: R$ ");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.Depositar(valorDeposito);
            Console.WriteLine("Dados da Conta atualizado:" + conta);

            Console.Write("Entre com o valor para saque: R$ ");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Sacar(valorSaque);
            Console.WriteLine("Dados da Conta atualizado:" + conta);
        }
    }
}
