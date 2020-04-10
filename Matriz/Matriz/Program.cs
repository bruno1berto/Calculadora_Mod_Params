using System;

namespace Matriz {
    class Program {
        static void Main(string[] args) {
            int intLinhas, intColunas;
            String strColunas = "L/C ";
            string strLinha = "";
            char chrLinhas = 'A';

            do {
                Console.WriteLine("Quantas Linhas sua Matriz terá (Máx. 10): ");
                intLinhas = int.Parse(Console.ReadLine());
            } while (intLinhas < 1 || intLinhas > 10);

            Console.WriteLine("Quantas Colunas sua Matriz terá: ");
            intColunas = int.Parse(Console.ReadLine());

            int[,] mat;
            mat = new int[intLinhas, intColunas];

            for (int i = 0; i < intLinhas; i++) {
                switch (i) {
                    case 0:
                        chrLinhas = 'A';
                        break;
                    case 1:
                        chrLinhas = 'B';
                        break;
                    case 2:
                        chrLinhas = 'C';
                        break;
                    case 3:
                        chrLinhas = 'D';
                        break;
                    case 4:
                        chrLinhas = 'E';
                        break;
                    case 5:
                        chrLinhas = 'F';
                        break;
                    case 6:
                        chrLinhas = 'G';
                        break;
                    case 7:
                        chrLinhas = 'H';
                        break;
                    case 8:
                        chrLinhas = 'I';
                        break;
                    case 9:
                        chrLinhas = 'J';
                        break;
                }
                for (int j = 0; j < intColunas; j++) {
                    Console.WriteLine("Informe o valor para a célula " + chrLinhas + (j + 1) + ": ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
                strColunas = strColunas + (i + 1) + "      ";
            }

            Console.WriteLine();
            Console.WriteLine("Sua Matriz:");
            Console.WriteLine();
            Console.WriteLine(strColunas);

            for (int i = 0; i < intLinhas; i++) {
                switch (i) {
                    case 0:
                        chrLinhas = 'A';
                        break;
                    case 1:
                        chrLinhas = 'B';
                        break;
                    case 2:
                        chrLinhas = 'C';
                        break;
                    case 3:
                        chrLinhas = 'D';
                        break;
                    case 4:
                        chrLinhas = 'E';
                        break;
                    case 5:
                        chrLinhas = 'F';
                        break;
                    case 6:
                        chrLinhas = 'G';
                        break;
                    case 7:
                        chrLinhas = 'H';
                        break;
                    case 8:
                        chrLinhas = 'I';
                        break;
                    case 9:
                        chrLinhas = 'J';
                        break;
                }
                for (int j = 0; j < intColunas; j++) {
                    String strTamanho = mat[i, j].ToString();
                    if (strTamanho.Length == 1) {
                        strLinha = strLinha + mat[i, j] + "      ";
                    }
                    else if (strTamanho.Length == 2) {
                        strLinha = strLinha + mat[i, j] + "     ";
                    }
                    else if (strTamanho.Length == 3) {
                        strLinha = strLinha + mat[i, j] + "    ";
                    }
                    else if (strTamanho.Length == 4) {
                        strLinha = strLinha + mat[i, j] + "   ";
                    }
                    else if (strTamanho.Length == 5) {
                        strLinha = strLinha + mat[i, j] + "  ";
                    }
                    else if (strTamanho.Length == 6) {
                        strLinha = strLinha + mat[i, j] + " ";
                    }
                }
                Console.WriteLine(chrLinhas + "   " + strLinha);
                strLinha = "";
            }

            Console.ReadLine();
        }
    }
}
