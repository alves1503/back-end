using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region Vetores
            //string[] nomes = {"Henrique ",
            //    "Pedro",
            //    "Maria"};

            //Console.WriteLine(nomes[0] + "| " + nomes[1]);
            //#endregion 

            //#region Matrizes
            //int[,] numeros2 = new int[2, 3];


            //numeros2[0, 0] = 10;
            //numeros2[0, 1] = 20;
            //numeros2[0, 2] = 30;

            //numeros2[1, 0] = 40;
            //numeros2[1, 1] = 50;
            //numeros2[1, 2] = 60;


            //Console.Write("[" + numeros2[0, 0] + "]");
            //Console.Write("[" + numeros2[0, 1] + "]");
            //Console.Write("[" + numeros2[0, 2] + "]");

            //Console.WriteLine();
            //Console.Write("[" + numeros2[1, 0] + "]");
            //Console.Write("[" + numeros2[1, 1] + "]");
            //Console.Write("[" + numeros2[1, 2] + "]");

            //Console.WriteLine();
            //string[,] nomes2 =
            //{
            //    {"Alves", "Pedro", "Ana"},
            //    {"Mario", "Charles", "Benedita"}
            //};

            //Console.WriteLine(nomes2[1, 2]);

            //#endregion



            #region Exercicios

            int[,] matriz1 =
            {
                { 5, 5, 3,},
                {5, 5, 1}

            };

            int[,] matriz2 =
            {
                {4, 2},
                {3, 3},
                {1, 5}
            };


            int res1 = matriz1[0,0] * matriz2[0,0] + matriz1[0,1] * matriz2[1,0] + matriz1[0,2] * matriz2[2,0];
            int res2 = matriz1[1, 0] * matriz2[0, 0] + matriz1[1, 1] * matriz2[1, 0] + matriz1[1, 2] * matriz2[2, 0]; 
            int res3 = matriz1[1, 0] * matriz2[0, 1] + matriz1[0, 1] * matriz2[1, 0] + matriz1[0, 2] * matriz2[2, 1];
            int res4 = matriz1[1, 0] * matriz2[0, 1] + matriz1[1, 1] * matriz2[1, 1] + matriz1[1, 2] * matriz2[2, 1];



            int[,] matrizRes =
            {
                {res1, res3},
                {res2, res4}
            };

            Console.Write("[" + res1 + "]");
            Console.Write("[" + res3 + "]");

            Console.WriteLine();

            Console.Write("[" + res2 + "]");
            Console.Write("[" + res4 + "]");




            #endregion

        }
    }
}
