using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios {
    public abstract class Funcionario {
    //O funcionario é uma abstracao dos conceitos dessa classe, fazendo com que ele não possa ser diretamente instanciado

        public static int TotalDeFuncionarios { get; private set; } 

        public string Nome {get;set;}
        public string CPF { get; private set; }
        public double Salario { get; protected set; }// Acesso entre classes de mesma hierarquia

        //Construtor para incrementar o TotalDeFuncionarios
        public Funcionario(double salario, string cpf) {
            Console.WriteLine("Criando Funcionario");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        //Aumento do salario
        public abstract void AumentarSalario();

        //Bonificacao
        public abstract double GetBonificacao();

    }
}
