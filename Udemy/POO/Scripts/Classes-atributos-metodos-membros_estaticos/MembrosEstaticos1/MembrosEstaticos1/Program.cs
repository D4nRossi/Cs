using System;

namespace MembrosEstaticos1
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(String[] args)
        {
            /*
             Membros estaticos
            - Tambem chamados membros de classe
            - Sao membros que fazem sentido independentemente de objetos. Nao precisam de objeto para serem chamados. Sao chamados a partir do proprio nome de classe

            Aplicacoes Comuns:
            - Classes utilitarias
            - Declaracao de constantes

            - Uma classe tambem possui somente membros estaticos, pode ser uma classe estatica tambem. Esta classe nao podera ser instanciada
             */

            //Problema exemplo
            /*Fazer um programa para ler um valor numerico qualquer, e dai mostrar quanto seria o valor de uma circunferencia e do volume de uma esfera para um raio daquele valor. Informar tambem o valor de PI com duas casas decimais*/


            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2"));
        }

        static double Circunferencia(double r)
        {
            return 2* Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}