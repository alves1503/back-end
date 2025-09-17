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


        // Metodos com retorno de valor
        public string MontaNome(string nome, string sobrenome)
        {
            string nomeCompleto = nome + " " + sobrenome;
            return nomeCompleto;
        }

        public int Soma(int x, int y)
        {
            return x + y;
        }

        public double ValorPi()
        {
            return 3.1415;
        }


        // Sobrecarga de metodos
        public void Nome(string nome)
        {

            Console.WriteLine($"Ola {nome}");

        }

        public void Cumprimentar(string nome, int hora)
        {
            string mensagem = hora < 12 ? $"Bom dia {nome}" : $"Boa tarde {nome}";
            Console.WriteLine(mensagem);

        }

        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }

    }
}
