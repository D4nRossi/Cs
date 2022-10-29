using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios {
    public class Diretor : Funcionario{
    //Classe diretor herda a classe Funcionario
        
        //Sobrepondo o metodo do Funcionario
        public override double GetBonificacao() {
            //referencia para a base (erro stack overflow)
            return Salario + base.GetBonificacao();
        }
    }
}
