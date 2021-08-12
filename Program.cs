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

            //Escolhe qual programa usar e converte para inteiro
            int opcao = int.Parse(Console.ReadLine());

             //Seleciona o programa correto para rodar
            switch (opcao)
            {
                case 1:
                    ControleVacina controle = new ControleVacina();
                    //Instancia um controle e chama seu metodo Comecar
                    controle.Comecar();
                    break;
                case 2:
                    //Cria 3 funcionarios, e chama ImprimirDados de todos
                    Funcionario f1 = new Funcionario("Nilze", Funcionario.ECargo.Estagiario);
                    Funcionario f2 = new Funcionario("Anne", Funcionario.ECargo.Junior);
                    Funcionario f3 = new Funcionario("Pamela", Funcionario.ECargo.Senior);
                    f1.ImprimirDados();
                    f2.ImprimirDados();
                    f3.ImprimirDados();
                    break;
                case 3:
                    //Cria 2 modelos e 2 atores e chama MostrarDados de todos
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
                    //Converte o valor lido do preço da moto para double (por ser dinheiro)
                    double valor = double.Parse(Console.ReadLine());
                    //Adiciona um desconto de 30% caso a compra seja a vista. Formata o valor com apenas 2 casas decimais
                    Console.WriteLine($"Compra a vista : {string.Format("R${0:N2}", valor * 0.7)}");

                    //Varivael para acrescentar o juros                    
                    double acrescimo = 1.04;
                    //Loop for para mostrar todas as possíveis parcelas.
                    //O incremento é de 6 em 6
                    for (int i = 5; i <= 29; i += 6)
                    {
                        //Adiciona um juros de acrescimo caso a compra seja parcelada em i vezes. Formata o valor com apenas 2 casas decimais
                        Console.WriteLine($"{i} Parcelas - Valor final: {string.Format("R${0:N2}", valor * acrescimo)}");
                        acrescimo += 0.03;
                    }
                    break;
            }
        }
    }
}
