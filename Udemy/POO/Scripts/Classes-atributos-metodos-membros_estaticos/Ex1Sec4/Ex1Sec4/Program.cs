using System;

namespace Ex1Sec4
{
    class Program
    {
        static void Main(String[] args)
        {
            //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha

            Person a, b;
            a = new Person();
            b = new Person();

            Console.WriteLine("Qual seu nome?");
            a.Name = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            a.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------");
            
            Console.WriteLine("Qual seu nome?");
            b.Name = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            b.Age = int.Parse(Console.ReadLine());

            if(a.Age > b.Age)
            {
                Console.WriteLine("O/A " + a.Name + " é mais velho/velha com: " + a.Age + " anos" );
            }else if(b.Age == a.Age)
            {
                Console.WriteLine("As duas pessoas tem a mesma idade, de: " + a.Age + " anos");
            }
            else
            {
                Console.WriteLine("O/A " + b.Name + " é mais velho/velha com: " + b.Age + " anos");
            }
        }
    }
}