using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {

        // Metodos simples
        public void MetodoSimples()
        {
            Console.WriteLine("Ola, seja bem vindo");
        }


        // Metodos com parametros
        public void Somar (int x, int y)
        {
            int res = x + y;
            Console.WriteLine($"A soma é {res}");
        }

        public void Apresentar(string nome, int idade)
        {

            Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");

        }


        // Passagem de parametros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine($"Valor final por parametros: {valor}");
        }


        // Passagem de parametros por referencia
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine($"Valor final por referencia: {valor}");
        }

    }
}
