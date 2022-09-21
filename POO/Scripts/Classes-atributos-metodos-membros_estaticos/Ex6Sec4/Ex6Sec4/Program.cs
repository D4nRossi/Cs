using System;

namespace Ex6Sec4
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Qual a cotacao do dollar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dollares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine());

            double result = Conversor.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em R$ = " + result.ToString("F2"));

        }
    }
}