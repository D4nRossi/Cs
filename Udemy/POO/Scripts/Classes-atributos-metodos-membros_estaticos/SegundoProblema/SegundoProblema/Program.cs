using System;

namespace SegundoProblema
{
    class Program
    {
        static void Main(String[] args)
        {

            /*
             Fazer um programa para ler os dados de um produto em estoque(nome, preco e quantidade no estoque).Em seguida:
            - Mostrar os dados do produto (nome, preco, quantidade no estoque, valor total no estoque)
            - Realizar uma entrada no estoque e mostrar novamente os dados do produto
            - Realizar uma saida no estoque e mostrar novamente os dados do produto
             */

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine().ToUpper();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
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