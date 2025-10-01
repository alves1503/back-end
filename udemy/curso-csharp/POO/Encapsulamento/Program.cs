using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Conta c = new Conta();
        

            //Operação
            double valor1 = 100;
            c.Depositar(valor1);

            
       


            //Resultado
            Console.WriteLine($"Cliente: {c.Cliente}");
            Console.WriteLine($"Saldo: {c.Saldo}");

            Console.ReadKey();


        }
    }
}
