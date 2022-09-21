using MembrosEstaticos2;
using System;

namespace MembrosEstaticos1
{
    class Program
    {
        
        static void Main(String[] args)
        {
   
            Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2"));
        }

        
    }
}