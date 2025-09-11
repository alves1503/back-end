using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {

       
        static void Main(string[] args)
        {

            #region Operador aritimetricos
            int a = 10;
            int b = 40;
            int soma = a + b;
            Console.WriteLine($"{a} + {b} = {soma}");
            #endregion

            #region Operadore com preferencia

            int num1 = 10;
            int num2 = 10;
            int dobro = (num2 + num2) * 2;
            Console.WriteLine(dobro);


            #endregion


            #region Operadore de incremento

            int id = 0;

            while (id < 5)
            {
                Console.WriteLine(id);
                id++;
            }



            #endregion


            #region Operador de concatenação

            string nome = "Henrique ";
            string sobrenome = "Alves";
            Console.WriteLine(nome + sobrenome);

            #endregion

            #region Operador de atribuição

            int valor1 = 10;
            valor1 *=  2;

            Console.WriteLine(valor1);



            #endregion

            #region Operados de igualdade

            int teste = 2;
            Console.WriteLine(teste == 2);



            #endregion

            #region Operadores relacionais

            int idade = 18;

            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade");
            } else
            {
                Console.WriteLine("Menor de idade");
            }





            #endregion


            #region Operadores logicos

            int teste1 = 2;
            if (teste1 < 10 && teste1 > 0)
            {
                Console.WriteLine("Aprovado");
            }



            #endregion


            #region Exercicio de coversor de temperatura

            Console.WriteLine("CONVERSOR DE TEMPERATURA");

            double  c, f, k;

            Console.Write("Digite a temperatura em graus celsius: ");
            c = double.Parse(Console.ReadLine());


            double temperaturaF = (c * 9 / 5) + 32;
            double temperaturaK = c + 273.15;
            Console.WriteLine($"{c}° equivale: {temperaturaF}f");
            Console.WriteLine($"{c}° equivale: {temperaturaK}k");




            #endregion


        }
    }
}
