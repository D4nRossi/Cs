/*
    Propriedades:
    - Sao definicoes de metodos encapsulados, porem expondo uma sintaxe similar a de atributos e nao metodos
    
 */

using System;
using This;

namespace Sobrecarga {
    class Program {
        static void Main(String[] args) {


            Produto p = new Produto("TV", 500, 10);
            p.Nome = "TV4K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}