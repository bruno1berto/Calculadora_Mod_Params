using System;
using System.Collections.Generic;
using System.Text;

namespace IntroPOO_Alunos {
    class Aluno {

        //Atributos
        public string Nome;
        public int Nota1;
        public int Nota2;
        public int Nota3;
        public float NotaFinal;

        //Métodos

        public void RecebeDadosAluno() {

            Console.Write("Digite o nome do Aluno: ");
            Nome = Console.ReadLine();

            do {
                Console.WriteLine();
                Console.Write("Digite a nota do 1° trimestre (Entre 0 e 30): ");
                Nota1 = int.Parse(Console.ReadLine());
            } while (Nota1 > 30 || Nota1 < 0);

            do {
                Console.WriteLine();
                Console.Write("Digite a nota do 2° trimestre (Entre 0 e 35): ");
                Nota2 = int.Parse(Console.ReadLine());
            } while (Nota1 > 35 || Nota1 < 0);

            do {
                Console.WriteLine();
                Console.Write("Digite a nota do 3° trimestre (Entre 0 e 35): ");
                Nota3 = int.Parse(Console.ReadLine());
            } while (Nota1 > 35 || Nota1 < 0);
        }

        public float CalculaMedia() {
            NotaFinal = Nota1 + Nota2 + Nota3;
            return NotaFinal;
        }

        public void ImprimeResultado() {
            CalculaMedia();
            Console.WriteLine("Aluno: " + Nome 
                + " | Nota 1: " + Nota1 
                + " | Nota 2: " + Nota2 
                + " | Nota 3: " + Nota3 
                + " | Nota Final: " + NotaFinal.ToString("F2"));
            Console.WriteLine();
            if(NotaFinal >= 60) 
                Console.WriteLine("Resultado: Aprovado.");
            else
                Console.WriteLine("Resultado: Reprovado. Faltaram " + (60 - NotaFinal) + " pontos para aprovação.");
        }
    }
}
