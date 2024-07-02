using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Curso_Udemy_Csharp_Essencial
{
    internal class Exercicio_5
    {
        public static string Pergunta1(char resposta)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Sua resposta pode estar incorreta verifique e responda novamente e x para sair");
                resposta = char.Parse(Console.ReadLine());
            }
            while (resposta != 'd');
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Resposta correta");
            return sb.ToString();
        }
    }
}