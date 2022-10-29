using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas {
    public interface IAutenticavel{
        //Em uma interface, todos os elementos são publicos
        bool Autenticar(string senha);
        
    }
}
