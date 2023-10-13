using System;

namespace ConversorDeMoeda {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual a cotação do dólar?: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você deseja comprar?: ");
            double quantidade = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.ConverterDolarParaReal(cotacao, quantidade).ToString("F2"));
        }
    }
}
