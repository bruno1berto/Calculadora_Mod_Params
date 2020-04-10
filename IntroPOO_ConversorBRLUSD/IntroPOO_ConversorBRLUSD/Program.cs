using System;

namespace IntroPOO_ConversorBRLUSD {
    class Program {

        static void Main(string[] args) {

            double cotacao, valor;

            Console.Write("Inofrme a cotação atual do Dolar: R$ ");
            cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Informe quanto pretende comprar em Dolar: U$ ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine();
            ConversorMoeda.Conversao(cotacao, valor);
        }

    }
}
