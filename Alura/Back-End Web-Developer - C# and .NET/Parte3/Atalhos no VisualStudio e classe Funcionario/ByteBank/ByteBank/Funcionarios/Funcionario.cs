using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios {
    public class Funcionario {

        //0 - Funcionario
        //1 - Diretor
        //2 - Designer
        //3 - Gerente de CC
        //4 - Coordenador
        private int _tipo;

        public string Nome {get;set;}
        public string CPF { get; set; }
        public double Salario { get; set; }

        //Bonificacao
        public virtual double GetBonificacao() {
            if(_tipo == 1) {
                return Salario;
            }return Salario * 0.10;
        }

    }
}
