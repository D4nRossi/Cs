using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios {
    public class Diretor : Funcionario{
    //Classe diretor herda a classe Funcionario
        
        public Diretor(string cpf) : base(5000, cpf) {
            Console.WriteLine("Criando Diretor");
        }

        public override void AumentarSalario() {
            Salario *= 1.15;
        }

        //Sobrepondo o metodo do Funcionario
        public override double GetBonificacao() {
            //referencia para a base (erro stack overflow)
            return Salario * 0.5;
        }
    }
}
