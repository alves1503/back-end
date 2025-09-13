using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Calcular IMC

            double altura, peso, seuImc;
            string nome, statusImc;


            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            seuImc = peso / (altura * altura); 



            if (seuImc < 18.5)
            {
                statusImc = "Magreza";
            } else if (seuImc < 24.9)
            {
                statusImc = "Peso Normal ou Adequado";
            } else if (seuImc < 29.9) 
                {
                statusImc = "Sobrepeso";
            } else if (seuImc < 39.9) {
                statusImc = "Obesidade (Graus I e II)";
            } else
            {
                statusImc = "Obesidade Grave ou Obesidade Grau III";
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine($"Ola, {nome}");
            Console.WriteLine($"Seu peso: {peso}");
            Console.WriteLine($"Sua altura: {altura}");
            Console.WriteLine($"Seu Imc: {Math.Round(seuImc,2)}");
            Console.WriteLine($"Status de Imc: {statusImc}");

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------");



        }
    }
}
