using System;


namespace ResolvendoProblemaSemPOO
{
    class Program
    {
        static void Main(String[] args)
        {
            /*
             Problema: fazer um programa para ler as medidas dos lados de dois triangulos X e Y (suponha medidas válidas). Em seguida, mostrar o valor das áreas dos dois triangulos e dizer qual dos dois triangulos possui maior area

                A formula para calcular a area de um triangulo a partir das medidas de seus lados a, b e c é a seguinte formula (Heron)
             */

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y");
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de x = " + areaX.ToString("F4"));
            Console.WriteLine("Área de y = " + areaY.ToString("F4"));

            if(areaX > areaY)
            {
                Console.WriteLine("Triangulo X tem maior area seno ela: " + areaX.ToString("F4"));
            }else if(areaX == areaY)
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
