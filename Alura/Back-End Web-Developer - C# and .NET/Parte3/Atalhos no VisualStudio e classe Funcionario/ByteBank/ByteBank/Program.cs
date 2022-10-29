using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank {
    class Program {
        static void Main(string[] args) {
            // CalcularBonificacao();

            UsarSistema();
             
        }

        public static void CalcularBonificacao() {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteCC camila = new GerenteCC("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor daniel = new Desenvolvedor("443.456.308.43");
            daniel.Nome = "Daniel";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(daniel);

            Console.WriteLine("Total de bonificacoes do mes: " + gerenciadorBonificacao.GetBonificacao());
        }

        public static void UsarSistema() {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteCC camila = new GerenteCC("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiro, "123456");
        }
    }
}