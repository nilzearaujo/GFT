using System;

namespace GFT
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha o programa:");
            Console.WriteLine("1 - Vacina");
            Console.WriteLine("2 - Funcionario");
            Console.WriteLine("3 - Modelo");
            Console.WriteLine("4 - Moto");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ControleVacina controle = new ControleVacina();
                    controle.Comecar();
                    break;
                case 2:
                    Funcionario f1 = new Funcionario("Nilze", Funcionario.ECargo.Estagiario);
                    Funcionario f2 = new Funcionario("Anne", Funcionario.ECargo.Junior);
                    Funcionario f3 = new Funcionario("Pamela", Funcionario.ECargo.Senior);
                    f1.ImprimirDados();
                    f2.ImprimirDados();
                    f3.ImprimirDados();
                    break;
                case 3:
                    Modelo m1 = new Modelo("Nilze", 1.60, 60, 35);
                    Modelo m2 = new Modelo("Meg", 1.70, 70, 24);
                    Ator a1 = new Ator("Pamela", 1.76, 87, 23);
                    Ator a2 = new Ator("Anne", 1.67, 71, 27);

                    m1.MostrarDados();
                    m2.MostrarDados();
                    a1.MostrarDados();
                    a2.MostrarDados();
                    break;
                case 4:
                    Console.WriteLine("Qual valor da moto?");
                    double valor = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Compra a vista : {string.Format("R${0:N2}", valor * 0.7)}");
                    double acrescimo = 1.04;
                    for (int i = 5; i < 29; i += 6)
                    {
                        Console.WriteLine($"{i} Parcelas - Valor final: {string.Format("R${0:N2}", valor * acrescimo)}");
                        acrescimo += 0.03;
                    }
                    break;
            }
        }
    }
}
