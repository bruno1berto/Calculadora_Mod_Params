using System;
using System.Collections.Generic; // Necessário para reconhecer o Objeto List

namespace Exercicio_Listas{
    class Program{
        static void Main(string[] args){

            List < Funcionarios > ListaFuncs = new List<Funcionarios>();

            Funcionarios.InsereFuncionarios(ListaFuncs);

            Console.WriteLine();

            Funcionarios.AumentaSalario(ListaFuncs);

            Console.ReadLine();

        }
    }
}
