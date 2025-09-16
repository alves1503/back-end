using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Metodos m = new Metodos();
            m.MetodoSimples();
            m.Somar(2, 10);
            m.Apresentar("Henrique", 20);


            int valor1 = 100;
            int valor2 = 200;
            m.AumentarValor(valor1);
            m.AumentarRef(ref valor2);

        }
    }
}
