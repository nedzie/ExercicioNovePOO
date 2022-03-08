using System;

namespace ExercicioNove.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno marcos = new Aluno();
            Console.Write("Digite quantas notas vai atrelar ao aluno: \n> ");
            marcos.quantiaDenotas = int.Parse(Console.ReadLine());
            marcos.notas = new double[marcos.quantiaDenotas];
            for (int i = 0; i < marcos.quantiaDenotas; i++)
            {
                Console.WriteLine("Informe a " + (i + 1) + "ª nota: ");
                marcos.notas[i] = double.Parse(Console.ReadLine());
            }
            marcos.mediaHarmonica = marcos.ObterMediaHamonica(marcos.quantiaDenotas, marcos.notas);

            Console.WriteLine("A média harmônica destas notas é de: " + marcos.mediaHarmonica.ToString("#.##") + ".");
        }
    }
}