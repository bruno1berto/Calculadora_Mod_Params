using System;
using System.Collections.Generic;
using System.Text;

namespace Poo_Banco {
    class Conta {

        static double TaxaSaque = 5.00;

        // Atributos privados
        private double _saldoConta;

        // Auto Properties
        public int NumeroConta { get; set; }
        public string TitularConta { get; set; }

        // Construtores
        public Conta(string titularConta, int numeroConta) {
            TitularConta = titularConta;
            NumeroConta = numeroConta;
        }

        // Properties Customizadas

        // Métodos
        public static void AbrirConta(List<Conta> listaContas){
            int qtd;
            Console.Write("Quantas Contas deseja inserir? ");
            qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++){
                Console.WriteLine();
                Console.WriteLine("Conta #" + (i+1));
                Console.Write("Informe o Nome do Titular da Conta: ");
                string titularConta = Console.ReadLine();
                Console.Write("Informe o Nº da Conta: ");
                int numeroConta = int.Parse(Console.ReadLine());
                listaContas.Add(new Conta(titularConta, numeroConta));
            }
            Console.WriteLine();
        }
        public static void EscolheOperacao(List<Conta> listaContas) {
            Console.WriteLine("Escolha a operação a ser realizada: ");
            Console.WriteLine("1 - Crédito");
            Console.WriteLine("2 - Débito");
            Console.WriteLine("3 - Transferência");
            Console.Write("Operação: ");
            char operacao;
            operacao = char.Parse(Console.ReadLine());
            while (operacao != '1' && operacao != '2' && operacao != '3') {
                Console.Write("Digite uma operação válida: ");
                operacao = char.Parse(Console.ReadLine());
            }
            if (operacao == '1') 
                CreditaConta(listaContas);
            else if (operacao == 2)  
                DebitaConta(listaContas);
            else
                Transferencia(listaContas);
        }

        public static void CreditaConta(List<Conta> listaContas) {
            Console.Write("Informe o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Conta conta = listaContas.Find(x => x.NumeroConta == numeroConta);
            Console.WriteLine();
            Console.WriteLine(conta.ToString());
            Console.Write("Digite o valor a ser Creditado: R$ ");
            double valor = double.Parse(Console.ReadLine());
            conta._saldoConta += valor;
            Console.WriteLine(conta.ToString());
            Console.WriteLine();
            Console.Write("Deseja realizar outra operação? S/N: ");
            char sn = char.Parse(Console.ReadLine());
            while (sn != 'S' && sn != 's' && sn != 'N' && sn != 'n') {
                Console.Write("Digite 'S' ou 'N': ");
                sn = char.Parse(Console.ReadLine());
            }
            if (sn == 'S' || sn == 's') {
                Console.WriteLine();
                EscolheOperacao(listaContas);
            }else{
                Console.WriteLine();
                Console.ReadLine();
            }
        }

        public static void DebitaConta(List<Conta> listaContas) {
            Console.Write("Informe o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Conta conta = listaContas.Find(x => x.NumeroConta == numeroConta);
            Console.WriteLine();
            Console.WriteLine(conta.ToString());
            Console.Write("Digite o valor a ser Debitado: R$ ");
            double valor = double.Parse(Console.ReadLine());
            while (valor <= 5) {
                Console.Write("Digite um valor maior que R$ 5,00: R$ ");
                valor = double.Parse(Console.ReadLine());
            }
            if ((TaxaSaque + valor) > conta._saldoConta) {
                Console.WriteLine("Saldo insuficiente.");
            }else{
                conta._saldoConta -= valor + TaxaSaque;
                Console.WriteLine(conta.ToString() + " | Taxa: " + TaxaSaque.ToString("F2"));
            }
            Console.WriteLine();
            Console.Write("Deseja realizar outra operação? S/N: ");
            char sn = char.Parse(Console.ReadLine());
            while (sn != 'S' && sn != 's' && sn != 'N' && sn != 'n') {
                Console.Write("Digite 'S' ou 'N': ");
                sn = char.Parse(Console.ReadLine());
            }
            if (sn == 'S' || sn == 's') {
                Console.WriteLine();
                EscolheOperacao(listaContas);
            }else{
                Console.WriteLine();
                Console.ReadLine();
            }
        }

        public static void Transferencia(List<Conta> listaContas){
            Console.Write("Digite o valor a ser Transferido: R$ ");
            double valor = double.Parse(Console.ReadLine());
            while (valor <= 5){
                Console.Write("Digite um valor maior que R$ 5,00: R$ ");
                valor = double.Parse(Console.ReadLine());
            }
            Console.Write("Informe o número da conta a ser Debitada: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Conta conta = listaContas.Find(x => x.NumeroConta == numeroConta);
            Console.WriteLine();
            Console.WriteLine(conta.ToString());
            if ((TaxaSaque + valor) > conta._saldoConta){
                Console.WriteLine("Saldo insuficiente.");
            }else{
                conta._saldoConta -= valor + TaxaSaque;
                Console.WriteLine(conta.ToString() + " | Taxa: " + TaxaSaque.ToString("F2"));
                Console.WriteLine();
                Console.Write("Informe o número da conta a ser Creditada: ");
                numeroConta = int.Parse(Console.ReadLine());
                conta = listaContas.Find(x => x.NumeroConta == numeroConta);
                Console.WriteLine();
                Console.WriteLine(conta.ToString());
                conta._saldoConta += valor;
                Console.WriteLine(conta.ToString());
            }
            Console.WriteLine();
            Console.Write("Deseja realizar outra operação? S/N: ");
            char sn = char.Parse(Console.ReadLine());
            while (sn != 'S' && sn != 's' && sn != 'N' && sn != 'n'){
                Console.Write("Digite 'S' ou 'N': ");
                sn = char.Parse(Console.ReadLine());
            }
            if (sn == 'S' || sn == 's'){
                Console.WriteLine();
                EscolheOperacao(listaContas);
            }else{
                Console.WriteLine();
                Console.ReadLine();
            }
        }

        public override string ToString() {
            return "Titular: " + TitularConta + " | Conta: " + NumeroConta + " | Saldo: " + _saldoConta.ToString("F2"); 
        }
    }
}
