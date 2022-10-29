using System;

namespace ExercicioResolvidoMatriz {
    class Program {
        static void Main(string[] args) {

            /*
                Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz
             */

            int n = int.Parse(Console.ReadLine());

            //Matriz n por n
            int[,] mat = new int[n, n];

            //loop para as linhas
            for(int i = 0; i < n; i++) {
                //loop para as colunas

                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            //loop para as diagonais
            Console.WriteLine("Main Diagonal: ");
            for(int i = 0; i < n; i++) {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            //Ver se tem numero negativo
            int count = 0;
            for(int i = 0; i < n; i++) {
                //Percorrer as colunas 
                for(int j = 0; j < n; j++) {
                    if (mat[i,j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative Numbers: " + count);
        }
    }
}
