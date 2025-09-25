using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Matematica
    {

        public void Soma (int x, int y)
        {
            Console.WriteLine($"O valor de {x} + {y} = {x + y}");
        }

        public void Subtracao(int x, int y)
        {
            Console.WriteLine($"O valor de {x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"O valor de {x} X {y} = {x * y}");
        }

        public void Divisao(int x, int y)
        {
            Console.WriteLine($"O valor de {x} / {y} = {x / y}");
        }


    }
}
