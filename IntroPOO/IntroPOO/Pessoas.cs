using System;
using System.Collections.Generic;
using System.Text;

namespace IntroPOO {
    class Pessoas {

        // Atributos
        public string Nome;
        public byte Idade;
        public bool DeMaior;

        // Metodos (principio da "Delegação de responsabilidades das classes")
        public bool Maior18() { // Retorna True ou False se a pessoa é maior de 18 anos
            if (Idade >= 18) 
                DeMaior = true;
            else
                DeMaior = false;
            return DeMaior;
        }
    }
}
