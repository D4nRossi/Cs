using System;
namespace ModificadoresDeParametrosRefEOut {
    class Program {
        static void Main(String[] args) {


            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int b = 10;
            int Triple1;
            Calculator.Triple1(b, out Triple1);
            Console.WriteLine(Triple1);

        }
    }
}