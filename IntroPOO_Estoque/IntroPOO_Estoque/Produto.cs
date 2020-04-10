using System;
using System.Collections.Generic;
using System.Text;

namespace IntroPOO_Estoque {
    class Produto {

        //Atributos privados OBS: No conceito de encapsulamento os atributos privados começam com _ + peimeira letra minúscula
        private string _nome;
        private double _preco;

        // Auto Propertires
        public int Quantidade { get; private set; } // Implementação de Auto Propertie com set bloqueado para outros arquivos 

        // Construtores
        public Produto(){ // Construtor padrão
        }

        public Produto(string nome, double preco, int quantidade) { // Construtor alternativo com 3 parâmetros
            _nome = nome;
            _preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) { // Construtor alternativo com 2 parâmetros. OBS: O parâmetro "Quantidade" é igual a zero por padrão.
            _nome = nome;
            _preco = preco;
        }
        // OBS: Ao implementar 2 ou mais construtores numa classe, recai-se o conceito de sobrecarga.

        // Properties customizadas (Properties encapsula os Gets e Sets)
        public string Nome {
            get {
                return _nome;
            }
            set {
                if (value != null && value.Length > 1)
                    _nome = value;
                else
                    Console.WriteLine("Nome inválido. Não houve alteração.");
            }
        }

        public double Preco {
            get {
                return _preco;
            }
            set {
                if(value >= 0)
                    _preco = value;
                else
                    Console.WriteLine("Preço inválido. Não houve alteração.");
            }
        }

        // Metodos
        public double ValorTotalEmEstoque() {
            return _preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
            Console.WriteLine("Dados Atualizados: " + ToString());
        }

        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
            Console.WriteLine("Dados Atualizados: " + ToString());
        }

        // Subiscrição(herança da classe genérica "Object") para formatar os parâmetros de um objeto em formato String.
        public override string ToString() {
            return _nome
                + ", R$ "
                + _preco.ToString("F2")
                + ", "
                + Quantidade
                + " Unidades, Valor Estoque: R$ "
                + ValorTotalEmEstoque().ToString("F2");
        }
        /* OBS: ToString é um método da classe "Object" e todas as classes nativas ou personalizadas são subclasses da calsse "Object", 
        portanto, herdam esse método. */
    }
}
