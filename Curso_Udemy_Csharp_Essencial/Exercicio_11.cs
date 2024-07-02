using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Udemy_Csharp_Essencial
{
    internal class Exercicio_11
    {
        public static int Caluladora(char Operador, int num1, int num2)
        {
            int resultado;
            switch (Operador)
            {
                case '+':
                    {
                        resultado = num1 + num2;
                        return resultado;
                    }
                case '-':
                    {
                        resultado = num1 - num2;
                        return resultado;
                    }
                case '*':
                    {
                        resultado = num1 * num2;
                        return resultado;
                    }
                case '/':
                    {
                        if (num2 == 0)
                        {
                            throw new ArgumentException($"O numero {num2} nao pode ser zero");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            return resultado;
                        }
                    }
                case '%':
                    {
                        if (num2 == 0)
                        {
                            throw new ArgumentException($"O numero {num2} nao pode ser zero");
                        }
                        else
                        {
                            resultado = num1 % num2;
                            return resultado;
                        }
                    }
                default:
                    {
                        throw new ArgumentException($"Operador {Operador} invalido");
                    }
            }
        }
    }
}