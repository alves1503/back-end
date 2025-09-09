using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entradaSaida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo!");
            Console.ReadKey();
            Console.Write("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine($"Seja bem vindo {nome}!");

        }
    }
}
