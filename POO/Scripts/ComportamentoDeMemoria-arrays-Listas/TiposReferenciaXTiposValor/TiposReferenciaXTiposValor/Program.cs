/*
 
Classes são tipos referencia
    - Variaveis cujo tipo são classes não devem ser entendidas como caixas, mas sim "tentaculos" (ponteiros) para caixas

Valor "null"
    - Tipos referencia aceitam o valor null, que indica que a variavel aponta para ninguem

Structs são tipos valor
    - A linguagem C# possui tambem tipos valor, que são os structs. Structs são CAIXAS e não ponteiros

 */

using System;

namespace TiposReferenciaXTiposValor {
    class Program {
        static void Main(String[] args) {
            
            //Exemplo de structures
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

        }
    }
}