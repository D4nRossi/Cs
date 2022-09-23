
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This {
    internal class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Metodo para obter o nome do produto
        public string GetNome() {
            return _nome;
        }

        //Metodo para mudar o nome do produto
        public void SetNome(string newNome) {
            if (newNome != null && newNome.Length > 1) {
                this._nome = newNome;
            }

        }

        //Definicao de Propertie
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    this._nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome + ", $" + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2");
        }
    }
}