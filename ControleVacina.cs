using System;
namespace GFT
{
    public class ControleVacina
    {
        public void Comecar()
        {
            Console.WriteLine("Qual vacina voce tomou?");
            Console.WriteLine("1 - Coronavac");
            Console.WriteLine("2 - Janseen");
            //Converte a string de ReadLine para um inteiro para ser verificado depois
            int vacina = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual dia voce tomou a vacina?");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual mes voce tomou a vacina?");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual ano voce tomou a vacina?");
            int ano = int.Parse(Console.ReadLine());
             //Lê do usuario o dia, mes e ano para montar uma data.
            DateTime data = new DateTime(ano, mes, dia);

            //Caso seja Coronavac
            if (vacina == 1)
            {
                Console.WriteLine($"Vacina : Coronavac");
                 //Mostra a data de forma simples (somente dia mes e ano)
                Console.WriteLine($"Primeira dose: {data.ToShortDateString()}");
                 //Mostra a data de forma simples da segunda dose, adicionando 14 dias
                Console.WriteLine($"Segunda dose: {data.AddDays(14).ToShortDateString()}");
            }
            //Caso seja Janseen
            if (vacina == 2)
            {
                Console.WriteLine($"Vacina : Janseen");
                 //Mostra a data de forma simples (somente dia mes e ano)
                Console.WriteLine($"Dose única: {data.ToShortDateString()}");
            }
        }
    }
}
