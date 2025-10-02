using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiicadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Teste t = new Teste();
            //t.nome = "Henrique";
            t.sobrenome = "Alves";

            //Console.WriteLine(t.nome);
            Console.WriteLine(t.sobrenome);
        }
    }
}
