using System;
namespace ExFixacaoSec6 {
    class Program {
        static void Main(string[] args) {

            // Array 10 de length
            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}: ");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Estudante(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }


        }
    }
}