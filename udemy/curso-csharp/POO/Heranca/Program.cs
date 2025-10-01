using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Carro c = new Carro();
            Bicicleta b = new Bicicleta();

            c.Cor = "Branco";
            c.Marca = "Gol";
            c.VelocidadeMaxima = 20;
            c.LigarMotor();
            c.Acelerar();
            c.Parou();
            Console.WriteLine(c.Cor);
            Console.WriteLine(c.Marca);

            Console.WriteLine("_____________________");

            b.Cor = "Branco";
            b.Marca = "Monarco";
            b.Pedalar();
            b.Acelerar();
            b.Parou();
            Console.WriteLine(b.Cor);
            Console.WriteLine(b.Marca);

            Console.WriteLine("_____________________");




        }
    }
}
