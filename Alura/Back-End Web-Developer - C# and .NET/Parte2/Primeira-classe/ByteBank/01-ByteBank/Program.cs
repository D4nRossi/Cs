using System;
namespace ByteBank {
    class Program {
        static void Main(string[] args) {
            // Conta corrente

            ContaCorrente conta1 = new ContaCorrente();

            conta1.titular = Console.ReadLine();
            conta1.agencia = int.Parse(Console.ReadLine());
            conta1.numero = int.Parse(Console.ReadLine());
            conta1.saldo = double.Parse(Console.ReadLine());

            Console.WriteLine();


        }
    }
}