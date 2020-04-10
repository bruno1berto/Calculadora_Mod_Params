using System;
using System.Collections.Generic;
using System.Text;

namespace IntroPOO_Statics {
    class Calculadora {

        public static double Pi = 3.14;

        public static double CalculaCircunferencia(double raio) {
            return 2 * Pi * raio;
        }

        public static double CalculaVolume(double raio) {
            return 4 / 3 * Pi * Math.Pow(raio, 3);
        }
    }
}
