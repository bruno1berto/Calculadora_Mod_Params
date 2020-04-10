using System;
using System.Collections.Generic;
using System.Text;

namespace IntroPOO_ConversorBRLUSD {
    class ConversorMoeda {

        //Atributos
        static double Iof = 6.00;

        public static void Conversao(double cotacao, double valor) {
            double aPagar = valor * cotacao + valor * cotacao * Iof / 100;
            Console.WriteLine("Valor a pagar: R$ " + aPagar.ToString("F2") + " (Iof: " + Iof.ToString("F2") + " %)");
            Console.ReadLine();
        }

    }
}
