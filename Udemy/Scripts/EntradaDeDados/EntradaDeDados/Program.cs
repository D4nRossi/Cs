using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(String[] args)
        {
            /*Console.ReadLine() 
              - Le da entrada padrão até a quebra de linha
              - Retorna na forma de String
            */


            /*
            String frase = Console.ReadLine();
            String x = Console.ReadLine();
            String y = Console.ReadLine();
            String z = Console.ReadLine();
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            String c = Console.ReadLine();

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a + " " + " " + b + " " + c);
            */

            /*
            String[] v = Console.ReadLine().Split(' ');// vai separar por espacos em branco
            String a = v[0];
            String b = v[1];
            String c = v[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */


            //PARTE 2

            /*
            //Console.ReadLine() só funciona com String, quando for outro tipo de valor usar o parse
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = Char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);  


            Console.WriteLine("Você digitou o numero");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2"));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);   
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));  
            */


            //Exercicio
            Console.WriteLine("Entre com seu nome completo");
            String name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto você pagou no seu pc?");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha)");
            string[] all = Console.ReadLine().Split(' ');
            string lastName = all[0];
            int age = int.Parse(all[1]);
            double height = double.Parse(all[2]);
            
            Console.WriteLine("-------------------------------");
            Console.WriteLine(name);
            Console.WriteLine(rooms);
            Console.WriteLine(price.ToString("F2"));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2"));




        }
    }
}