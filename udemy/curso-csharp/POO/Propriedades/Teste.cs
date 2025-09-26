using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Teste
    {


        //Definição de campo
        private string _nome;
        private string _sobrenome { get; } = "Henrique";

        private int _idade;


        //Definição de propriedade
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }


        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine($"Não é permitido valores menores de 18");
                }
                else
                {
                    _idade = value;
                }
            }
        }




        public void Apresentar()
        {
            Console.WriteLine($"Bem vindo {_nome} {_sobrenome}");
        }

    }
}
