using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //            📝 Exercício 2 – Tabuada Personalizada

        //Crie um programa em C# que:


        //Peça ao usuário um número inteiro.

        //Mostre a tabuada desse número de 1 a 10, usando um laço de repetição(pode ser for).

        //No final, pergunte se o usuário deseja calcular outra tabuada.

        //Se digitar S, o programa repete.

        //Se digitar N, o programa encerra.

        Inicio:
            int valorTabuada;
            char funcaoEscolhida, verificar;
            double resultado = 0;

            Console.Clear();
          


            //Vai ler o valor a ser realizado a operação
            Console.Write("Digite o valor que deseja saber a tabuada: ");
            valorTabuada = int.Parse(Console.ReadLine());

            Console.Write("Digite a operação para saber a tabuada (+, -, X, /: ");
            funcaoEscolhida = char.Parse(Console.ReadLine());


            switch (funcaoEscolhida)
            {
                //Função soma
                case '+':
                    for (int i = 0; i <= 10; i++)
                    {
                        resultado = valorTabuada + i;
                        Console.WriteLine($"{valorTabuada} + {i} = {resultado}");

                    }
                    break;

                    //Função subtração
                case '-':
                    for (int i = 0; i <= 10; i++)
                    {
                        resultado = valorTabuada - i;
                        Console.WriteLine($"{valorTabuada} - {i} = {resultado}");

                    }
                    break;

                //Função multiplicação
                case 'x':
                case 'X':
                    for (int i = 0; i <= 10; i++)
                    {
                        resultado = valorTabuada * i;
                        Console.WriteLine($"{valorTabuada} X {i} = {resultado}");

                    }
                    break;

                //Função divisao
                case '/':
                    for (int i = 1; i <= 10; i++)
                    {
                        resultado = valorTabuada / i;
                        Console.WriteLine($"{valorTabuada} / {i} = {Math.Round(resultado, 2)}");

                    }
                    break;

                default:
                    Console.WriteLine("Error,você digitou algum campo invalido!");
                    goto Inicio;
            }


            Console.Write("Voccê deseja continuar a tabuada (s,n): ");
            verificar = char.Parse(Console.ReadLine());

            if (verificar == 's' || verificar == 'S')
            {
                goto Inicio;
            } else
            {
                Console.WriteLine("Fim tabuada!");
            }



        }
    }
}
