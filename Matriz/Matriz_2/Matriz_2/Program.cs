using System;

namespace Matriz_2{
    class Program{
        static void Main(string[] args){

            Console.Write("Digite as quantidades de Linhas e Colunas (use 'Espaço'): ");
            string s = Console.ReadLine();
            
            string[] vet = s.Split(' ');
            int nL = int.Parse(vet[0]);
            int nC = int.Parse(vet[1]);

            int[,] matriz = new int[nL, nC];

            Console.WriteLine();
            Console.WriteLine("Digite " + nC + " números separados por 'Espaço' em " + nL + " linhas:");

            for (int i = 0; i < matriz.GetLength(0); i++) {
                s = Console.ReadLine();
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    vet = s.Split(' ');
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }
            
            Console.WriteLine();
            Console.Write("Digite um número na matriz: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    if (matriz[i,j] == num) {
                        Console.WriteLine();
                        Console.WriteLine("Ocorrência na Posição: " + i + "," + j);
                        if (j > 0 && matriz[i, j - 1] != 0) {
                            Console.WriteLine("Elemento à Esquerda: " + matriz[i, j - 1]);
                        }
                        if (j < matriz.GetLength(1)-1 && matriz[i, j + 1] != 0) {
                            Console.WriteLine("Elemento à Direita: " + matriz[i, j + 1]);
                        }
                        if (i > 0 && matriz[i - 1, j] != 0) {
                            Console.WriteLine("Elemento Acima: " + matriz[i - 1, j]);
                        }
                        if (i < matriz.GetLength(0)-1 && matriz[i + 1, j] != 0) {
                            Console.WriteLine("Elemento Abaixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
