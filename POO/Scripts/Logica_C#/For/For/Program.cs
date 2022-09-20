using System;

namespace For
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for(int i = 1; i <= N; i++)
            {
                Console.Write("Valor : #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.Write("Soma igual a: " + soma);
        }
    }
}