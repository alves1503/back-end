using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Estatico
            //Matematica.taxa = 20;

            //int valor1 = Matematica.Adicionar(100);
            //int valor2 = Matematica.Diminuir(50);


            //Console.WriteLine($"Valor 1: {valor1}");
            //Console.WriteLine($"Valor 2: {valor2}");
            #endregion


            Pessoa.maiorIdade = 21;

            Pessoa p1 = new Pessoa();
            p1.nome = "Henrique";
            p1.idade = Pessoa.CalcularIdade(2000);


            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);




        }
    }
}
