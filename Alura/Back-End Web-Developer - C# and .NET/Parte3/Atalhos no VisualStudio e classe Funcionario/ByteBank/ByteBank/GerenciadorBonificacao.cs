using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank {
    public class GerenciadorBonificacao {

        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario) {
            _totalBonificacao  += funcionario.GetBonificacao();
        }
        

        public double GetBonificacao() { 
            return _totalBonificacao;
        }

    }
}
