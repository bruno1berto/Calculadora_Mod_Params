using System;

namespace IntroPOO_Alunos {
    class Program {
        static void Main(string[] args) {

            Aluno A = new Aluno();

            A.RecebeDadosAluno();
            Console.WriteLine();
            A.ImprimeResultado();
            Console.ReadLine();

        }
    }
}
