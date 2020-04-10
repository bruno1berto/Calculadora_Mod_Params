using System;

namespace IntroPOO_Statics {
    class Program {
        static void Main(string[] args) {

            // Calculadora Pi
            double raio;

            Console.Write("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Circunferência: " + Calculadora.CalculaCircunferencia(raio));
            Console.WriteLine("Volume: " + Calculadora.CalculaVolume(raio));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi);

            Console.ReadLine();

            // NOTA:
            // Não foi preciso instaciar um objeto do tipo calculadora para acessar seus atributos e métodos, sendo possível acessá-los
            // apenas referenciando o nome da classe "Calculadora.CalculaCicrcunferencia(raio)"

        }
    }
}
