using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_004 {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double aumento) {
            SalarioBruto = SalarioBruto + (SalarioBruto * aumento / 100);
        }

        public override string ToString() {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2");
        }
    }
}
