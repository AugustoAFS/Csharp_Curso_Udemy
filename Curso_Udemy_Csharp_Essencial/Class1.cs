using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Udemy_Csharp_Essencial
{
    internal class Exercicio_8
    {
        public static long Fatorial(long numero)
        {
            if (numero < 0)
            {
                throw new ArgumentOutOfRangeException("numero", "Fatorial cannot be calculated for negative numbers.");
            }
            else
            {
                long resultado = 1;

                for (long i = numero; i > 0; i--)
                {
                    resultado *= i;
                }
                return resultado;
            }
        }
    }
}
