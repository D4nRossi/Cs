using System;

namespace Ex4Sec4
{
    class Program
    {
        static void Main(String[] args)
        {
            Employe Dan = new Employe();
            
            Console.Write("Nome: ");
            Dan.Name = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            Dan.Salary = double.Parse(Console.ReadLine().ToString());

            Console.Write("Imposto: ");
            Dan.Taxes = double.Parse(Console.ReadLine().ToString());

            Console.WriteLine(Dan.General());
            Console.WriteLine();

            Console.Write("Quer um aumento de quantos porcento? ");
            Dan.Percent = double.Parse(Console.ReadLine().ToString());
            Console.WriteLine(Dan.RaiseSalary());
        }
    }
}