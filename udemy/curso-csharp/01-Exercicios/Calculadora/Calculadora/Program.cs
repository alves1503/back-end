using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Inicio:

            Console.Clear();

            Console.Write("DIGITE O PRIMEIRO VALOR: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("DIGITE O SEGUNDO VALOR: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("ESCOLHA A OPERAÇÃO: (+ - X / ): ");
            char opcaoCalculo = char.Parse(Console.ReadLine());

            double resultado = 0;


            switch (opcaoCalculo)
            {
                case '+':
                    resultado = valor1 + valor2;
                    Console.WriteLine($"O resultado da soma entre {valor1} e {valor2} é: {resultado}");
                  
                        break;

                case '-':
                    resultado = valor1 - valor2;
                    Console.WriteLine($"O resultado da subtração entre {valor1} e {valor2} é: {resultado}");

                    break;

                case 'x' :
                case 'X':
                    resultado = valor1 * valor2;
                    Console.WriteLine($"O resultado da multiplicação entre {valor1} e {valor2} é: {resultado}");

                    break;

                case '/':
                    resultado = valor1 / valor2;
                    Console.WriteLine($"O resultado da divisão entre {valor1} e {valor2} é: {resultado}");

                        break;

                default:
                    Console.WriteLine("Erro, você não prencheu os devidos campos! Tente novamente");
                    goto Inicio;




            }

            Console.Write("Continuar Calculando (s / n) ?");
            char continuar = char.Parse(Console.ReadLine());
            if (continuar == 's' || continuar == 'S')
            {
                goto Inicio;
            }




        }



    }
    
}
