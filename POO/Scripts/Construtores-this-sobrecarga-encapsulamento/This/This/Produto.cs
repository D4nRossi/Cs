using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }

        // O this reaproveita o argumento do construtor padrao
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;//linha dispensavel
        }

        // Reaproveitando nome e preco do construtor anterior
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {

        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
