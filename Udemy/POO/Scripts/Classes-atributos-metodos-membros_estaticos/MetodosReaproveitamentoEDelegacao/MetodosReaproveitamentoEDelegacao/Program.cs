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

            double areaX = x.Area();
            double areaY = y.Area();
            
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