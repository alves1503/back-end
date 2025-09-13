using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaControles
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Switch case
            int escolha = 1;

            switch (escolha) {

                case 1:
                    Console.WriteLine("Ola");
                    break;
                   

                case 2:
                    Console.WriteLine("Tudo bem");
                    break;

                case 3:
                    Console.WriteLine("Como vai");
                    break;

                default:
                    Console.WriteLine("Erro");
                    break;
                  
            }
        #endregion


        Inicio:

            Console.Write("Escolha uma opção: ");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;


            switch (op)
            {
                default:
                    Console.WriteLine("Opção invalida!");
                    goto Inicio;
                    break;
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;
            }

            Console.WriteLine("Valor final: " + valor);


        }
    }
}
