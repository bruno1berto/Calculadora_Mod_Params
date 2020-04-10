using System;

namespace Pensionato {

    class Program {
        static void Main(string[] args) {

            int QtdTotalQuartos = 10;

            Hospedes[] pensionato = new Hospedes[QtdTotalQuartos];

            Console.WriteLine("Pensionato da Maria");
            Console.WriteLine();

            Hospedes.ReservarQuartos(pensionato, QtdTotalQuartos);

            Console.ReadLine();

        }
    }
}
