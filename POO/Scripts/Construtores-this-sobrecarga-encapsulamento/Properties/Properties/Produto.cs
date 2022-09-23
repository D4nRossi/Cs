﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This {
    internal class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
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

        public double Preco {
            get { return this._preco; }
        }

        public int Quantidade {
            get { return this._quantidade; }
        }

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome + ", $" + _preco.ToString("F2") + ", " + _quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2");
        }
    }
}