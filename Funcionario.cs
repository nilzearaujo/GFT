using System;

namespace GFT
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
        public double Salario { get; private set; }

 //Construtor para receber os valores iniciais
        public Funcionario(string nome, ECargo cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }


        public void ImprimirDados()
        {
            string tipoTrabalho = "";
            //Selectiona o cargo e coloca as variaveis corretas
            switch (Cargo)
            {
                case ECargo.Estagiario:
                    tipoTrabalho = "100% home office";
                    Salario = 800;
                    break;
                case ECargo.Junior:
                    tipoTrabalho = "Presencial";
                    Salario = 1200;
                    break;
                case ECargo.Senior:
                    tipoTrabalho = "Híbrido";
                    Salario = 2500;
                    break;
            }
            //Formata o salario para aparecer apenas 2 digitos após a vírgula
            Console.WriteLine($"{Nome} - {Cargo} - {string.Format("R${0:N2}", Salario)} - {tipoTrabalho}");
        }

        //Enum para comparar o Cargo do funcionario
        public enum ECargo
        {
            Estagiario, Junior, Senior
        }
    }

}