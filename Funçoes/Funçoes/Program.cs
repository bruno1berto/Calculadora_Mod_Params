using System;

namespace Funçoes{
    class Program{ 
        public static int ProdutoDoisNs(int n1, int n2){
            int prod;
            prod = n1 * n2;
            return prod;
        }
        static void Main(string[] args){
            int num1, num2;

            Console.Write("Digite um número inteiro: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número inteiro: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("O produto entre " + num1 + " e " + num2 + " é: " + ProdutoDoisNs(num1, num2));

            Console.ReadLine();
        }
    }
}
