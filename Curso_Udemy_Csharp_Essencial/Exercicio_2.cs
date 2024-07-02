using System;

namespace Curso_Udemy_Csharp_Essencial
{
    internal class Exercicio_2
    {
        public static (double raiz1, double raiz2) Bhaskara(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("O coeficiente 'a' não pode ser zero para uma equação do segundo grau.");
            }
            else
            {
                double discriminante = (Math.Pow(b, 2) - 4 * a * c);

                if (discriminante >= 0)
                {
                    double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                    return (raiz1, raiz2);
                }
                else
                {
                    return (double.NaN, double.NaN);
                }
            } 
        }
    }
}