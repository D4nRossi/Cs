using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFixacaoSec5Pt1 {
    internal class ContaBancaria {

        //Encapsulamento dos atributos
        public int Numero { get;private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Construtores
        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular){
            Deposito(depositoInicial);
        }

        //Operacoes
        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia;
            //Taxa
            Saldo -= 5.0;
        }

        public override string ToString() {
            return "Conta " +
                    Numero +
                    ", Titular: " +
                    Titular +
                    ", Saldo: $" +
                    Saldo.ToString("F2");
        }


    }
}
