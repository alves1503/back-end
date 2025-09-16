using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Pessoa p1 = new Pessoa();
            p1.nome = "Henrique";
            p1.sobrenome = "Alves";
            p1.anoNascimento = 2005;



            Pessoa p2 = new Pessoa()
            {
                nome = "Maria",
                sobrenome = "Clara",
                anoNascimento = 2010
            };


            Console.WriteLine($"Pessoa 1 = {p1.nome}");
            Console.WriteLine($"Pessoa 1 = {p1.sobrenome}");
            Console.WriteLine($"Pessoa 1 = {p1.anoNascimento}");
            p1.ExibirInformacao();

            Console.WriteLine();

            Console.WriteLine($"Pessoa 2 = {p2.nome}");
            Console.WriteLine($"Pessoa 2 = {p2.sobrenome}");
            Console.WriteLine($"Pessoa 2 = {p2.anoNascimento}");
            p2.ExibirInformacao();

            Console.ReadKey();



        }
    }

    class MinhaClasse
    {

    }
}
