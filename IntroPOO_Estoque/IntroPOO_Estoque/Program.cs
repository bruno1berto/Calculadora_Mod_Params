using System;

namespace IntroPOO_Estoque {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(); // Objeto instaciado com o construtor padrão da classe "Produto"
            Produto p2 = new Produto(nome, preco, quantidade); // Objeto instaciado fornecendo os paramêtros do construtor da classe "Produto" com 3 parâmetros.
            Produto p3 = new Produto(nome, preco); // Objeto instaciado fornecendo os paramêtros do construtor da classe "Produto" com 2 parâmetros.

            Console.WriteLine("Dados do Produto: " + p2); // Com a subiscrição basta informar o objeto e ele será convertido automaticamente em stringo com a formatação definida na classe.
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            p2.AdicionarProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            p2.RemoverProduto(int.Parse(Console.ReadLine()));

            p2.Nome = "TV 4K"; // p2.Nome não é uma representação de acesso a um atributo e sim um acesso através da uma properties.
            p2.Nome = "T";

            Console.ReadLine();
        }
    }
}
