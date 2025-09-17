using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            Crie um programa em C# que:

            //Peça ao usuário o nome, o peso(kg) e a altura(m).

            //Calcule o IMC = peso / (altura * altura).

            //Mostre na tela o nome da pessoa, o valor do IMC e a classificação:

            //            Abaixo do peso: IMC < 18,5

            //Peso normal: 18,5 ≤ IMC < 25

            //Sobrepeso: 25 ≤ IMC < 30

            //Obesidade: IMC ≥ 30


            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu peso (kg): ");
            int seuPeso = int.Parse(Console.ReadLine());
            Console.Write("Digite sua altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double seuImc = seuPeso / (altura * altura);
            string informacao;

            if(seuImc < 18.5)
            {
                informacao = "Abaixo do peso";
            } else if (seuImc < 25)
            {
                informacao = "Peso normal";
            } else if (seuImc < 30)
            {
                informacao = "Sobrepeso";
            } else
            {
                informacao = "Obesidade";
            }

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"Seja bem vindo {nome}, sua altura: {altura}, seu peso: {seuPeso} \n" +
                $"Você possui um IMC: {Math.Round(seuImc,2)}, considerado: {informacao}");


        }
    }
}
