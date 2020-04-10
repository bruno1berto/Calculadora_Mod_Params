using System;

namespace Pensionato {
    class Hospedes {

        // Auto Properties
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        // Construtores
        public Hospedes() {

        }
        public Hospedes(string nome, string email, int quarto) {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        // Métodos
        public static void ReservarQuartos(Hospedes[] pensionato, int qtdTotalQuartos) {

            int totalQuartos = qtdTotalQuartos -1;

            System.Console.Write("Quantos quartos serão reservados (Máx. " + qtdTotalQuartos + "): ");
            int qtdReservas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (qtdReservas < 1 || qtdReservas > qtdTotalQuartos) {
                System.Console.Write("Quantidade inválida. Digite um número entre 1 e " + qtdTotalQuartos + ": ");
                qtdReservas = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Hospedes h0, h1, h2, h3, h4, h5, h6, h7, h8, h9;

            for (int i = 0; i < qtdReservas; i++) {
                
                string nome, email;
                int quarto;

                Console.Write("Informe o nome do " + (i+1) + "º Hospede: ");
                nome = Console.ReadLine();
                Console.Write("Informe o email do " + (i+1) + "º Hospede: ");
                email = Console.ReadLine();
                Console.Write("Informe o quarto a ser reservado (1 - " + qtdTotalQuartos + "): ");
                quarto = int.Parse(Console.ReadLine());

                while (quarto < 0 || quarto > totalQuartos) {
                    Console.Write("Quarto inválido. Informe um quarto entre (1 - " + qtdTotalQuartos + "): ");
                    quarto = int.Parse(Console.ReadLine());
                }

                if (i == 0) {
                    h0 = new Hospedes(nome, email, quarto);
                    while (pensionato[quarto-1] != null) {
                        Console.Write("Este quarto já foi reservado. Informe outro quarto: ");
                        quarto = int.Parse(Console.ReadLine());
                        h0.Quarto = quarto;
                    }
                    pensionato[quarto-1] = h0;
                    Console.WriteLine("Reserva realizada.");
                }
                else if (i == 1) {
                    h1 = new Hospedes(nome, email, quarto);
                    while (pensionato[quarto-1] != null) {
                        Console.Write("Este quarto já foi reservado. Informe outro quarto: ");
                        quarto = int.Parse(Console.ReadLine());
                        h1.Quarto = quarto;
                    }
                    pensionato[quarto-1] = h1;
                    Console.WriteLine("Reserva realizada.");
                }
                else if (i == 2) {
                    h2 = new Hospedes(nome, email, quarto);
                    while (pensionato[quarto-1] != null) {
                        Console.Write("Este quarto já foi reservado. Informe outro quarto: ");
                        quarto = int.Parse(Console.ReadLine());
                        h2.Quarto = quarto;
                    }
                    pensionato[quarto-1] = h2;
                    Console.WriteLine("Reserva realizada.");
                }
                else if (i == 3) {
                    h3 = new Hospedes(nome, email, quarto);
                    while (pensionato[quarto-1] != null) {
                        Console.Write("Este quarto já foi reservado. Informe outro quarto: ");
                        quarto = int.Parse(Console.ReadLine());
                        h3.Quarto = quarto;
                    }
                    pensionato[quarto-1] = h3;
                    Console.WriteLine("Reserva realizada.");
                }
                else if (i == 4) {
                    h4 = new Hospedes(nome, email, quarto);
                    while (pensionato[quarto-1] != null) {
                        Console.Write("Este quarto já foi reservado. Informe outro quarto: ");
                        quarto = int.Parse(Console.ReadLine());
                        h4.Quarto = quarto;
                    }
                    pensionato[quarto-1] = h4;
                    Console.WriteLine("Reserva realizada.");
                }
                else if (i == 5) {
                    h5 = new Hospedes(nome, email, quarto);
                    while (pensionato[quarto-1] != null) {
                        Console.Write("Este quarto já foi reservado. Informe outro quarto: ");
                        quarto = int.Parse(Console.ReadLine());
                        h5.Quarto = quarto;
                    }
                    pensionato[quarto-1] = h5;
                    Console.WriteLine("Reserva realizada.");
                }
                else if (i == 6) {
                    h6 = new Hospedes(nome, email, quarto);
                    while (pensionato[quarto-1] != null) {
                        Console.Write("Este quarto já foi reservado. Informe outro quarto: ");
                        quarto = int.Parse(Console.ReadLine());
                        h6.Quarto = quarto;
                    }
                    pensionato[quarto-1] = h6;
                    Console.WriteLine("Reserva realizada.");
                }
                else if (i == 7) {
                    h7 = new Hospedes(nome, email, quarto);
                    while (pensionato[quarto-1] != null) {
                        Console.Write("Este quarto já foi reservado. Informe outro quarto: ");
                        quarto = int.Parse(Console.ReadLine());
                        h7.Quarto = quarto;
                    }
                    pensionato[quarto-1] = h7;
                    Console.WriteLine("Reserva realizada.");
                }
                else if (i == 8) {
                    h8 = new Hospedes(nome, email, quarto);
                    while (pensionato[quarto-1] != null) {
                        Console.Write("Este quarto já foi reservado. Informe outro quarto: ");
                        quarto = int.Parse(Console.ReadLine());
                        h8.Quarto = quarto;
                    }
                    pensionato[quarto-1] = h8;
                    Console.WriteLine("Reserva realizada.");
                }
                else if (i == 9) {
                    h9 = new Hospedes(nome, email, quarto);
                    while (pensionato[quarto-1] != null) {
                        Console.Write("Este quarto já foi reservado. Informe outro quarto: ");
                        quarto = int.Parse(Console.ReadLine());
                        h9.Quarto = quarto;
                    }
                    pensionato[quarto-1] = h9;
                    Console.WriteLine("Reserva realizada.");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < qtdTotalQuartos; i++) {
                if (pensionato[i] != null) {
                    Console.WriteLine(pensionato[i].ToString());
                }
            }
        }
            // Subscrição
        public override string ToString() {
            return "Quarto " + Quarto + " reservado para o Hospede: " + Nome + " | E-mail: " + Email;
        }
    }
}
