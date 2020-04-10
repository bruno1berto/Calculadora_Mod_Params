using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Listas{
    class Funcionarios {

        // Auto Properties
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        // Construtores
        public Funcionarios(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        // Métodos
        public static void InsereFuncionarios(List<Funcionarios> funcionarios){
            Console.Write("Quantos funcionários serão registrados: ");
            int qtdFunc = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Insira os dados dos Funcionários: ");

            for (int i = 0; i < qtdFunc; i++){
                int indice = i + 1;
                Console.WriteLine();
                Console.WriteLine("Funcionario #" + indice);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: R$ ");
                double salario = double.Parse(Console.ReadLine());
                funcionarios.Add(new Funcionarios(id,nome,salario));
            }
        }

        public static void AumentaSalario(List<Funcionarios> funcionarios){

            Console.Write("Informe o Id do Funcionário que terá o aumento: ");
            int id = int.Parse(Console.ReadLine());

            Funcionarios func = funcionarios.Find(x => x.Id == id);
            if (func != null) {
                func.Salario += func.Salario * 0.1;
                Console.WriteLine("Lista atualizada: ");
                Console.WriteLine();
                foreach (Funcionarios obj in funcionarios){
                    Console.WriteLine(obj.ToString());
                }
            }else{
                Console.WriteLine("Id inválido ou não encontrado.");
            }
        }

        // Subscrição
        public override string ToString(){
            return "Id: " + Id
                + ", " + Nome
                + ", R$ " + Salario.ToString("F2");
        }
    }
}
