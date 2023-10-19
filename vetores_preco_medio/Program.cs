using System;

namespace vetores_preco_medio {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for(int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("Preço médio = " + avg.ToString("F2"));
        }
    }
}
