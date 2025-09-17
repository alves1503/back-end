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

            #region Metodos
            //Metodos m = new Metodos();
            //m.MetodoSimples();
            //m.Somar(2, 10);
            //m.Apresentar("Henrique", 20);


            //int valor1 = 100;
            //int valor2 = 200;
            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2);
            #endregion


            #region Metodos com  retorno de valor
            //string nomeCompleto = m.MontaNome("Henrique", "Alves");
            //int soma = m.Soma(100, 50);
            //double pi = m.ValorPi();

            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(soma);
            //Console.WriteLine(pi);
            #endregion


            m.Cumprimentar("Henrique", 18);

            bool res1 = m.Comparar(11, 10);
            Console.WriteLine(res1);
        }
    }
}
