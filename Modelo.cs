using System;
namespace GFT
{
    public class Modelo
    {
        public string Nome { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public int Idade { get; set; }
        public Modelo(string nome, double altura, double peso, int idade)
        {
            Nome = nome;
            Altura = altura;
            Peso = peso;
            Idade = idade;
        }

        public virtual void MostrarDados()
        {
            Console.WriteLine($"{Nome} - Malhação");
        }
    }

    public class Ator : Modelo
    {
        public string NivelAtor { get; set; }
        public Ator(string nome, double altura, double peso, int idade) : base(nome, altura, peso, idade)
        {
            NivelAtor = "Ator";
        }

        public override void MostrarDados()
        {
            Console.WriteLine($"{Nome} - Novela");
        }
    }

}