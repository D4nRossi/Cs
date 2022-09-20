using System;
using System.Runtime.CompilerServices;

// conversao implcita é quando uma variavel de um tipo pode ser atribuida a outra de outro tipo
// casting é a conversão explícita entre dois tipos compativeis

namespace ConversaoImplicitaECasting
{
    class Program
    {
        static void Main (String[] args)
        {

            float x = 4.5f; // float = 4bytes
            double y = x; // double = 8bytes
            //Console.WriteLine(y);

            double a;
            float b;

            a = 4.5;
            b = (float)a; // definicao de casting
            //Console.WriteLine(b);

            double c;
            int d;

            c = 4.5;
            d = (int)c;
            //Console.WriteLine(d);


            int e;
            int f;

            e = 5;
            f = 2;

            double result = (double)e / f;
            Console.WriteLine (result);

        }
    }
}
