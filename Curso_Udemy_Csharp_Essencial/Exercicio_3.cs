using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Udemy_Csharp_Essencial
{
    internal class Exercicio_3
    {
        public static long SomaNumero(long numero)
        {
            long soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += numero;
                numero++;
            }

            return soma;
        }
    }
}