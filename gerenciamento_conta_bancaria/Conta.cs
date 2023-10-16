using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace gerenciamento_conta_bancaria {
    class Conta {
        public int NumeroConta { get; private set; } //Numero nunca deve mudar
        public string NomeTitular { get; set; } //Pessoa pode alterar o nome (casamento, retificação, etc)
        public double SaltoTotal { get; private set; }

        public Conta(int numeroConta, string nomeTitular) {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public Conta(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular) {
            Depositar(depositoInicial);
        }

        public void Depositar(double valorDeposito) {
            SaltoTotal += valorDeposito;
        }

        public void Sacar(double valorSaque) {
            SaltoTotal -= valorSaque + 5;
        }

        public override string ToString() {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + NomeTitular
                + ", Saldo: R$ "
                + SaltoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
