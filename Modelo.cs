using System;
namespace GFT
{
    public class Modelo
    {
        public string Nome { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public int Idade { get; set; }

        //Construtor para receber os valores iniciais
        public Modelo(string nome, double altura, double peso, int idade)
        {
            Nome = nome;
            Altura = altura;
            Peso = peso;
            Idade = idade;
        }

         //Metodo virtual para mostrar os dados de um Modelo. Pode ser sobrescrito por classes filhas
        public virtual void MostrarDados()
        {
            Console.WriteLine($"{Nome} - Malhação");
        }
    }

    public class Ator : Modelo
    {
        public string NivelAtor { get; set; }

        //Construtor que passa os valores para base e coloca o valor "Ator" em NivelAtor
        public Ator(string nome, double altura, double peso, int idade) : base(nome, altura, peso, idade)
        {
            NivelAtor = "Ator";
        }

         //Metodo sobrescrito de Modelo. Ator só atua em novela
        public override void MostrarDados()
        {
            Console.WriteLine($"{Nome} - Novela");
        }
    }

}