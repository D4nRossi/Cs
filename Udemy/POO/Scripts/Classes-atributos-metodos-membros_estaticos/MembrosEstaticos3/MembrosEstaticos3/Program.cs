using MembrosEstaticos2;
using System;

namespace MembrosEstaticos1
{
    class Program
    {

        static void Main(String[] args)
        {

            

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2"));
        }


    }
}
