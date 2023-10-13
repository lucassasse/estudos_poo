using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDeMoeda {
    class ConversorDeMoeda {
        public static double Iof = 6.0;

        public static double ConverterDolarParaReal(double cotacao, double quantidade) {
            return cotacao * quantidade * (1 + Iof / 100);
        }
    }
}
