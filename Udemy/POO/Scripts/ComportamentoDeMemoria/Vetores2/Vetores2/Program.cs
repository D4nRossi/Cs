using System;
using System.Security.Cryptography;

namespace Vetores2 {
    class Program {
        static void Main(string[] args) {

            /*
             Problema exemplo 2
                Fazer um programa para ler um numero inteiro N e os dados (nome e preco) de N produtos. Armazene os N produtos em um vetor. Em seguida, mostrar o preco médio dos produtos.
             */

            int n = int.Parse(Console.ReadLine());

            //Criando o vetor
            Product[] vect = new Product[n];

            for(int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product {
                    Name = name,
                    Price = price
                };
            }

            double sum = 0;
            for(int i =0; i < n; i++) {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("Average Price: " + avg.ToString("F2"));

        }
    }
}