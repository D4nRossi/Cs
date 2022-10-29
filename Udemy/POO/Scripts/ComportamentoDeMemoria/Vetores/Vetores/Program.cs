using System;

namespace Vetores {
    class Program {
        static void Main(string[] args) {

            /*
             Problema exemplo 1
                Fazer um programa para ler um número inteiro N e a altura de N pessoas. Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas
             */

            int n = int.Parse(Console.ReadLine());

            // Criacao de um vetor contendo doubles, que recebe o tamano do n
            double[] vect = new double[n];
            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine());
            }

            // Soma do vetor
            double sum = 0;
            for(int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("Average Height: " + avg.ToString("F2"));
        }
    }
}