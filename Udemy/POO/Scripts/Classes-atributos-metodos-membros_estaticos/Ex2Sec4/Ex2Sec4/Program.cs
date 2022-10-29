using System;
namespace Ex2Sec4
{
    class Program
    {
        static void Main(String[] args)
        {
            // Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários

            Employe a, b;
            a = new Employe();
            b = new Employe();

            double pay;

            Console.Write("Nome: ");
            a.Name = Console.ReadLine();
            Console.Write("Salario: ");
            a.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------");

            Console.Write("Nome: ");
            b.Name = Console.ReadLine();
            Console.Write("Salario: ");
            b.Salary = double.Parse(Console.ReadLine());

            pay = Medium(a.Salary, b.Salary);
            Console.Write("Salário médio: " + pay);
        }

        static double Medium(double a, double b)
        {
            double x;
            x = (a + b) / 2;
            return x;
        }
    }
}