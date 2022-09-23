using System;

namespace SintaxeAlternativaParaInicializarValores
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine().ToUpper();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());

            Produto p = new Produto() { 
                Nome = "TV", 
                Preco = 900.00, 
                Quantidade = 5 
            };

            Console.WriteLine("Dados do produto " + p);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}