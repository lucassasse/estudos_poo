using System;

namespace vetores_altura_media {
    class Program {
        static void Main(string[] args) {
            Console.Write("Tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i = 0; i < n; i++) {
                Console.Write("Valor a ser armazenado na posição " + i + " do vetor: ");
                vect[i] = double.Parse(Console.ReadLine());
            }
            
            Console.WriteLine();

            double sum = 0.0;
            for(int i = 0; i < n; i++) {
                sum += vect[i];
            }
            
            double avg = sum / n;

            for(int i = 0; i < n; i++) {
                Console.WriteLine("Valor do vetor na posição " + i + " é: " + vect[i]);
            }

            Console.WriteLine("Altura média = " + avg.ToString("F2"));
        }
    }
}
