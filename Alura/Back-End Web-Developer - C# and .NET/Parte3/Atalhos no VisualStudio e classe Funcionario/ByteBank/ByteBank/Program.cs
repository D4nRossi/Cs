using ByteBank.Funcionarios;
using System;

namespace ByteBank {
    class Program {
        static void Main(string[] args) {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "443.456.308.43";
            carlos.Salario = 2000;
            
            gerenciador.Registrar(carlos);


            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "554.567.419.54";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificacao de uma referencia de Funcionario: " + roberta.GetBonificacao());
            gerenciador.Registrar(robertaTeste);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificacoes: " + gerenciador.GetBonificacao());
        }
    }
}