using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {                   

            Pessoa p1 = new Pessoa();

            p1.nome = "Henrique";

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.sobrenome);
            Console.WriteLine(p1.anoNascimento);
            Console.WriteLine(p1.idade);


            Console.WriteLine("____________________________________");
            Pessoa p2 = new Pessoa("Henrique", "Alves", 2005);
            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.sobrenome);
            Console.WriteLine(p2.anoNascimento);
            Console.WriteLine(p2.idade);


        }
    }
}
