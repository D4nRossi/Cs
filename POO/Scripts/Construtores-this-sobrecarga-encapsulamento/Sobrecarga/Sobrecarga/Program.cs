using System;

namespace Sobrecarga
{
    class Program
    {
        static void Main(String[] args)
        {
            /*
             Sobrecarga:
             - É um recurso que uma classe possui de oferecer mais de uma operacao com o mesmo nome, porem com diferentes listas de parametros
             */

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine().ToUpper();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());

            //Construtor de apenas dois argumentos
            Produto p = new Produto(nome, preco);
            //Construtor padrao
            Produto p2 = new Produto();

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