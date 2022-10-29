using CriandoClasseRepresentarMelhor;
using System;

namespace CriandoClassesRepresentarMelhor
{
    class Program
    {
        static void Main(String[] args)
        {
           Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de x = " + areaX.ToString("F4"));
            Console.WriteLine("Área de y = " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("Triangulo X tem maior area sendo ela: " + areaX.ToString("F4"));
            }
            else if (areaX == areaY)
            {
                Console.WriteLine("Os dois tem a mesma area sendo elas: " + areaX.ToString("F4"));
            }
            else
            {
                Console.WriteLine("Triangulo Y tem maior area sendo ela: " + areaY.ToString("F4"));
            }
        }
    }
}