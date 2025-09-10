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

            string nome1, nome2, nome3;

            Console.Write("Digite o nome 1: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o nome 2: ");
            nome2 = Console.ReadLine();

            Console.Write("Digite o nome 3: ");
            nome3 = Console.ReadLine();


            Console.WriteLine($"Seja bem vindo: {nome1}");
            Console.WriteLine($"Seja bem vindo: {nome2}");
            Console.WriteLine($"Seja bem vindo: {nome3}");



        }
    }
}
