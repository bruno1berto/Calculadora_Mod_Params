using System;
using System.Collections.Generic;

namespace Poo_Banco {
    class Program {
        static void Main(string[] args) {

            List<Conta> ListaContas = new List<Conta>();

            Conta.AbrirConta(ListaContas);

            Conta.EscolheOperacao(ListaContas);
        }
    }
}
