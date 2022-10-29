using System;

namespace ByteBank {
    class Program {
        static void Main(string[] args) {

            ContaCorrente conta = new ContaCorrente();

            conta.titular = Console.ReadLine();
            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);

        }
    }
}
