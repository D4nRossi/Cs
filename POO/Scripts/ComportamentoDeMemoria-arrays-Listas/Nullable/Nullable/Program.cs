/*
 
    Nullable:
        - É um recurso de C# para que dados de tipo valor (structs) possam receber o valor null
        - 

    Uso comum:
        - Campos em banco de dados que podem valer nulo (data de nascimento, algum valor numerico, etc.).
        - Dados e parametros opcionais

    
        
 */

using System;
namespace Nullable {
    class Program {
        static void Main(string[] args) {

            /*
             Versão longa
             Nullable<double> x = null;
             */

            //Versão curta
            double? x = 0;
            double? y = 10.0;

            /*
                Metodos:
                    - GetValueOrDefault
                    - HasValue
                    - Value (lanca uma excecão se não houver valor)
             */

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            } else {
                Console.WriteLine("X é nulo");  
            }

            if (y.HasValue) {
                Console.WriteLine(y.Value);
            } else {
                Console.WriteLine("Y é nulo");
            }

            //Operador de coalescência nula
            double? x1 = null;
            double? z1 = 10.0;
            //Se o valor de x1 não for nulo, ele joga o valor dele para o y1, mas se ele for nulo, ele pega o 0.0
            double y1 = x1 ?? 0.0;
            double a = z1 ?? 0.0;

            Console.WriteLine("----------------------------");
            Console.WriteLine(y1);
            Console.WriteLine(a);

        }
    }
}