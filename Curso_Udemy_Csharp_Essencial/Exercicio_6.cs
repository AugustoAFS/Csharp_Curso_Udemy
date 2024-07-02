using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Curso_Udemy_Csharp_Essencial
{
    internal class Exercicio_6
    {
        public static string NumerosDoisDois(int numerosDois)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 10; i <= numerosDois; i = i + 2)
            {
                if (i == 16)
                {
                    continue;
                }
                else
                {
                    sb.AppendLine($"O resultado: {i}");
                }
            }
            return sb.ToString();
        }

        public static string NumeroUmUm(int numeroUm)
        {
            StringBuilder cd = new StringBuilder();
            for(int i = 10;i <= numeroUm; i++)
            {
                if (i == 16) 
                {
                    continue;
                }
                else
                {
                    cd.AppendLine($"O resultado: {i}");
                }
            } 
            return cd.ToString();
        }
    }
}