using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Estrutura While

            int valor = 0;
            int count = 0;

            while (count < 5)
            {
                valor += count;
                Console.WriteLine(valor);
                count++;
            }


            #endregion

            #region Estrutura do while

            int x = 2;

            do
            {
                Console.WriteLine("Exectado");

            } while (x > 3);




            #endregion

            #region Estrutura for

            int calculadora = 12;

            for (int i = 0; i <= 10; i++)
            {
                int multiplicacao = calculadora * i;
                Console.WriteLine($"{calculadora} X {i} = {multiplicacao}");
            }


            #endregion

            #region Estrutura foreach

            string[] nomes =
            {
                "Henrique", "Pedro", "Marcos"
            };

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }



            #endregion



        }
    }
}
