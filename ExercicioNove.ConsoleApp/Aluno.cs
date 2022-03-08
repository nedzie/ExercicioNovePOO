using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioNove.ConsoleApp
{
    internal class Aluno
    {
        public int quantiaDenotas;
        public double[] notas;
        public double mediaHarmonica;

        public double ObterMediaHamonica(int quantiaDeNotas, double[] notas)
        {
            double somaTotalNotas = 0;
            for (int i = 0; i < quantiaDenotas; i++)
            {
                somaTotalNotas += 1 / notas[i];
            }
            mediaHarmonica = quantiaDenotas / somaTotalNotas;
            return mediaHarmonica;
        }
    }
}