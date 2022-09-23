/*
    Propriedades autoimplementadas:
    - É uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares para as operacoes get e set

    public double Preco{get; private set;}
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