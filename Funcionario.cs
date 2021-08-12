using System;

namespace GFT
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, ECargo cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }


        public void ImprimirDados()
        {
            string tipoTrabalho = "";
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
            Console.WriteLine($"{Nome} - {Cargo} - {string.Format("R${0:N2}", Salario)} - {tipoTrabalho}");
        }

        public enum ECargo
        {
            Estagiario, Junior, Senior
        }
    }

}