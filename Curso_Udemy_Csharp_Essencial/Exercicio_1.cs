using System;

namespace Curso_Udemy_Csharp_Essencial
{
    internal class Exercicio_1
    {
        public static (int menor, int maior) EncontrarMaiorMenor(int num1, int num2, int num3)
        {
            int menor = num1;
            int maior = num1;

            if (num2 < menor)
            {
                menor = num2;
            }
            else if (num2 > maior)
            {
                maior = num2;
            }

            if (num3 < menor)
            {
                menor = num3;
            }
            else if (num3 > maior)
            {
                maior = num3;
            }

            return (menor, maior);
        }
    }
}
