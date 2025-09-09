using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 20;
            double real = 20.5;
            char letra = 'a';
            Console.WriteLine(inteiro);
            Console.ReadKey();
            Console.WriteLine(real);
            Console.WriteLine(letra);


            bool verdadeiro = true; // Variavel tipo booleana

            string nome = "Henrique Alves Gonçalves";
            Console.WriteLine(nome);

            var numero = 2;
            var teste = "Ola";
            Console.WriteLine(teste);
            Console.WriteLine(numero);

            object obj = 100;
        }
    }
}
