using System;

namespace Ex3Sec4
{
    class App
    {
        static void Main(String[] args)
        {
            /*
             Fazer um programa para ler os valores da largura e altura de um retangulo. Em seguida, mostrar na tela o valor de sua area, perimetro e diagonal
             */

            Rectangle x = new Rectangle();

            Console.Write("Entre a largura do retangulo: ");
            x.Width = double.Parse(Console.ReadLine());
            Console.Write("Entre a altura do retangulo:  ");
            x.Height = double.Parse(Console.ReadLine());

            Console.Write("A area do retangulo é de: " + x.Area().ToString("F2"));
            
            Console.WriteLine();

            Console.Write("O perimetro do retangulo é de: " + x.Perimeter().ToString("F2"));

            Console.WriteLine();

            Console.Write("A diagonal é de: " + x.Diagonal().ToString("F2"));

        }
    }
}