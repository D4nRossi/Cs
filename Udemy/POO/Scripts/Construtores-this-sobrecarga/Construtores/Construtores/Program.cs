using System;

namespace Construtores
{
    class Program
    {
        static void Main(String[] args)
        {
            /*
             Construtor:
            - É uma operacao especial de classe, que executa no momento da instanciacao do objeto
            - Usos comuns:
                - Iniciar valores dos atributos
                - Permitir ou obrigar que o objeto receba dados / dependencias no momento de sua instanciacao (injecao de dependencia)
            - Se um construtor customizado nao for especificado, a classe disponibiliza o construtor padrao:
                - Produto p = new Produto();
            - É possível especificar mais de um construtor na mesma classe (sobrecarga)
             */

           

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine().ToUpper();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

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