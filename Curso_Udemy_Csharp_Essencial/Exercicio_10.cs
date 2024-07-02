using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Udemy_Csharp_Essencial
{
    internal class Exercicio_10
    {
        public static string NotaAluno()
        {
            int somaDasNotas = 0;
            int numeroDeNotas = 0;
            int Nota;

            for (int i = 0; i <=4 ; i++)
            {
                Console.Write("Insira a nota do aluno (ou um número negativo para sair): ");
                Nota = int.Parse(Console.ReadLine());
                if (Nota >= 0)
                {
                    somaDasNotas += Nota;
                    numeroDeNotas++;
                }
                else
                {
                    break;
                }
            }

            if (numeroDeNotas == 0)
            {
                return "Nenhuma nota foi inserida.";
            }
            else
            {
                double media = (double)somaDasNotas / numeroDeNotas;
                if (media == 10)
                {
                    return $"Média das notas: {media}\nA+";
                }
                else if (media == 9)
                {
                    return $"Média das notas: {media}\nA";
                }
                else if(media == 7 || media == 8)
                {
                    return $"Média das notas: {media}\nB";
                }
                else if(media == 6)
                {
                    return $"Média das notas: {media}\nC";
                }
                else
                {
                    return $"Média das notas: {media}\nReprovado";
                }
            }
        }
    }
}