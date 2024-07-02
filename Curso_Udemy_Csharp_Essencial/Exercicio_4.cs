using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Udemy_Csharp_Essencial
{
    internal class Exercicio_4
    {
        public static string Tabuada(int Numero)
        {
            if (Numero == 0)
            {
                throw new ArgumentOutOfRangeException("Numero não pode ser zero!!");
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Tabuada do {Numero}:\n");
                for (int i = 0; i <= 10; i++)
                {
                    int resultado = Numero * i;
                    sb.AppendLine($"{Numero} * {i} = {resultado}");
                }
                return sb.ToString();
            }

        }
    }
}
