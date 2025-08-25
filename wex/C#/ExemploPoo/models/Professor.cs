using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.models
{
    
    public class Professor : Pessoa
    {

        public Professor(string nome) : base(nome)
        {
            
        }


        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {Nome}, tenho {Idade} anos, sou professor e meu salario é de {Salario}");
        }

    }
}