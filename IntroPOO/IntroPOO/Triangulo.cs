using System;
using System.Collections.Generic;
using System.Text;

namespace IntroPOO {
    class Triangulo {
        
        // Atributos
        public double A;
        public double B;
        public double C;
        public double Area;

        // Metodos (principio da "Delegação de responsabilidades das classes")
        // calcula área do triangulo (formulá de Heron)
        public double CalculaArea() { // Por se tratar de um metodo de uma classe a função não precisa de parametros usando nesse caso os atributos da classe.
            double p = (A + B + C) / 2;
            Area = Math.Sqrt(p*(p-A)*(p-B)*(p-C));
            return Area;
        }

    }
}
