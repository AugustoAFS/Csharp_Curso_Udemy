using System;
using System.Diagnostics.Metrics;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Curso_Udemy_Csharp_Essencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char prosseguir;
            int escolha = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Lista de Exercícios!");
                Console.WriteLine("1-Descobrir qual dos numeros e o maior e menor\n2-Bhaskara\n3-soma dos numeros subsequentes\n4-Tabuada\n5-Perguntas sobre programacao\n6-Teste de break e continue\n7-Arvore de natal\n8-Fatorial\n9-Tabuada\n10-Media\n11-Calculadora\n");
                Console.WriteLine("Digite o número do exercício que deseja executar:");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        ExecutarExercicio1();
                        break;
                    case 2:
                        ExecutarExercicio2();
                        break;
                    case 3:
                        ExecutarExercicio3();
                        break;
                    case 4:
                        ExecutarExercicio4();
                        break;
                    case 5:
                        ExecutarExercicio5();
                        break;
                    case 6:
                        ExecutarExercicio6();
                        break;
                    case 7:
                        ExecutarExercicio7();
                        break;
                    case 8:
                        ExecutarExercicio8();
                        break;
                    case 9:
                        ExecutarExercicio9();
                        break;
                    case 10:
                        ExecutarExercicio10();
                        break;
                    case 11:
                        ExecutarExercicio11();
                        break;
                    default:
                        Console.WriteLine("Exercício inválido. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nDeseja continuar? (S/s)");
                prosseguir = char.Parse(Console.ReadLine());
            } while (prosseguir == 'S' || prosseguir == 's');
        }

        private static void ExecutarExercicio1()
        {
            int num1, num2, num3;

            Console.Write("Maior e menor");

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            (int menor, int maior) resultado = Exercicio_1.EncontrarMaiorMenor(num1, num2, num3);

            Console.WriteLine("Menor: {0}", resultado.menor);
            Console.WriteLine("Maior: {0}", resultado.maior);

        }

        private static void ExecutarExercicio2()
        {
            double a, b, c;

            Console.Write("Bhaskara");

            Console.Write("Digite o valor do coeficiente 'a': ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do coeficiente 'b': ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do coeficiente 'c': ");
            c = double.Parse(Console.ReadLine());

            (double raiz1, double raiz2) resultado = Exercicio_2.Bhaskara(a, b, c);

            Console.WriteLine("Raiz 1: {0}", resultado.raiz1);
            Console.WriteLine("Raiz 2: {0}", resultado.raiz2);
        }

        private static void ExecutarExercicio3()
        {
            long numeroInicial;

            Console.Write("soma dos numeros");

            Console.Write("Digite o número inicial da sequência: ");
            numeroInicial = long.Parse(Console.ReadLine());

            long resultado = Exercicio_3.SomaNumero(numeroInicial);
            Console.WriteLine("{0}",resultado);
        }

        private static void ExecutarExercicio4()
        {
            Console.WriteLine("Tabuada");

            Console.WriteLine("Digite um numero no qual sera a tabuada:");
            int Tabuada = int.Parse(Console.ReadLine());

            string tabuada = Exercicio_4.Tabuada(Tabuada);
            Console.WriteLine(tabuada);
        }
        private static void ExecutarExercicio5()
        {
            Console.WriteLine("Qual a instrução para sair de um loop?");
            Console.WriteLine("a.quit\nb.continue\nc.break\nd.exit");
            char Resposta = char.Parse(Console.ReadLine());
            Exercicio_5.Pergunta1(Resposta);
        }
        private static void ExecutarExercicio6()
        {
            Console.WriteLine("Digite o numero 20 ou mais:");
            int numero = int.Parse(Console.ReadLine());
            string resultado1 = Exercicio_6.NumerosDoisDois(numero);
            string resultado2 = Exercicio_6.NumeroUmUm(numero);
            Console.WriteLine("{0}\n{1}", resultado2, resultado1);
        }
        private static void ExecutarExercicio7()
        {
            Console.WriteLine("Digite um caracter para fazer uma pseudo arvore:");
            char opcao = char.Parse(Console.ReadLine());
            string Resultado = Exercicio_7.ArvoreNatal(opcao);
            Console.WriteLine(Resultado);
        }
        private static void ExecutarExercicio8()
        {
            Console.WriteLine("Digite um numero para descobrir o seu fatorial:");
            long numero = long.Parse(Console.ReadLine());
            long fatorial = Exercicio_8.Fatorial(numero);
            Console.WriteLine("Fatorial de {0}: {1}", numero, fatorial);
        }
        private static void ExecutarExercicio9()
        {
            ExecutarExercicio4();
        }
        private static void ExecutarExercicio10()
        {
            Console.WriteLine("Media");
            string resultado = Exercicio_10.NotaAluno();
            Console.WriteLine(resultado);
        }
        private static void ExecutarExercicio11()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Insira o primeiro numero:");
            int Numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha qual opcao voce deseja cacular:");
            char operador = char.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero");
            int Numero2 = int.Parse(Console.ReadLine());

            int resultado = Exercicio_11.Caluladora(operador,Numero1, Numero2);

            Console.WriteLine(resultado);

        }
    }
}