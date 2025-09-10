using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão implicita
            byte num1 = 100;
            ushort num2;

            num2 = num1;

            #endregion

            #region Conversão explicita
            ushort num3 = 100;
            byte num4 = (byte)num3;

            float num5 = 2500f;
            int num6 = (int)num3;

            Console.WriteLine(num6);


            #endregion

            #region Metodo Parse

            string txtNumero = "250,45";
            double numero = double.Parse(txtNumero);

            Console.WriteLine(numero);


            #endregion

            #region Metodo Convert

            string valor1 = "1000,500";
            double valorConvert = Convert.ToDouble(valor1);

            Console.WriteLine(valorConvert);

            #endregion

        }
    }
}
