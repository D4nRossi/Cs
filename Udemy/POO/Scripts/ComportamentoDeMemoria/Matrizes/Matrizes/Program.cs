using System;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {

            //Declarar o tipo de dado da matriz
            double[,] mat = new double[2, 3]; //Matriz de 2 rows e 3 columns

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);//Quantidade de linhas
            Console.WriteLine(mat.GetLength(0));//Dimensao 0 = row / dimensao 1 = column

        }
    }
}
