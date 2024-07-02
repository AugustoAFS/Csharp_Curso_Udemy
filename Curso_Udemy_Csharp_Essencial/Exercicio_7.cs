using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Udemy_Csharp_Essencial
{
    internal class Exercicio_7
    {
        public static string ArvoreNatal(char arvore)
        {
            StringBuilder Texto = new StringBuilder();

            for (int i = 0; i <= 4; i++)
            {
                string linha = new string(arvore, i + 1);
                Texto.AppendLine(linha);
            }

            return Texto.ToString();
        }
    }
}