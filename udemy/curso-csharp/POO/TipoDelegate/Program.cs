using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate void Operacao(int num1, int num2);
        static void Main(string[] args)
        {

            Matematica m = new Matematica();

            Operacao conta = null;

            conta += m.Divisao();

            conta(10, 20);

            Console.ReadKey();
             
             

        }
    }
}
