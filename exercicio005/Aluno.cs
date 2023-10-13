using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio005 {
    class Aluno {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public bool VerificaAprovacao() {
            if(NotaFinal() >= 60) {
                return true;
            } else {
                return false;
            }
        }

        public double NotaFaltante() {
            if (VerificaAprovacao()) {
                return 0.0;
            } else {
                return 60 - NotaFinal();
            }
        }
    }
}
