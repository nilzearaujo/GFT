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
            int vacina = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual dia voce tomou a vacina?");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual mes voce tomou a vacina?");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual ano voce tomou a vacina?");
            int ano = int.Parse(Console.ReadLine());
            DateTime data = new DateTime(ano, mes, dia);

            if (vacina == 1)
            {
                Console.WriteLine($"Vacina : Coronavac");
                Console.WriteLine($"Primeira dose: {data.ToShortDateString()}");
                Console.WriteLine($"Segunda dose: {data.AddDays(14).ToShortDateString()}");
            }
            if (vacina == 2)
            {
                Console.WriteLine($"Vacina : Janseen");
                Console.WriteLine($"Dose única: {data.ToShortDateString()}");
            }
        }
    }
}