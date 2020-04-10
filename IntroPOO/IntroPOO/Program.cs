using System;

namespace IntroPOO {
    class Program {
        static void Main(string[] args) {

            // Calcula a área de 2 triangulos e verifica qual tem a maior área.
            
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Calcula a área de 2 triangulos e verifica qual tem a maior área");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Digite os valores dos lados do triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            x.CalculaArea();

            Console.WriteLine("Digite os valores dos lados do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());
            y.CalculaArea();

            Console.WriteLine();
            Console.WriteLine("A área do triangulo X é: " + x.Area.ToString("F4"));
            Console.WriteLine("A área do triangulo Y é: " + y.Area.ToString("F4"));
            Console.WriteLine();

            if (x.Area > y.Area)
                Console.WriteLine("O triangulo X é maior.");
            else if(x.Area == y.Area)
                Console.WriteLine("Os triangulos têm áreas equivalentes.");
            else
                Console.WriteLine("O triangulo Y é maior.");

            Console.WriteLine();
            Console.WriteLine();

            // Compara a idade entre 2 pessoas

            Pessoas p1, p2;

            p1 = new Pessoas();
            p2 = new Pessoas();

            Console.WriteLine("Compara a idade entre 2 pessoas");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Digite o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa: ");
            p1.Idade = byte.Parse(Console.ReadLine());
            p1.Maior18();

            Console.WriteLine();
            Console.WriteLine("Digite o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa: ");
            p2.Idade = byte.Parse(Console.ReadLine());
            p2.Maior18();

            Console.WriteLine();

            if (p1.DeMaior && p2.DeMaior)
                Console.WriteLine(p1.Nome + " e " + p2.Nome + " são maiores de 18 anos.");
            else if (p1.DeMaior == true)
                Console.WriteLine(p1.Nome + " é maior de 18 anos.");
            else
                Console.WriteLine(p2.Nome + " é maior de 18 anos.");

            if (p1.Idade > p2.Idade)
                Console.WriteLine(p1.Nome + " é mais velho que " + p2.Nome);
            else if (p1.Idade == p2.Idade)
                Console.WriteLine(p1.Nome + " e " + p2.Nome + " têm a mesma idade.");
            else
                Console.WriteLine(p2.Nome + " é mais velho que " + p1.Nome);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();

        }
    }
}
