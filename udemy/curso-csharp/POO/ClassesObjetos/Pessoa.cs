using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {

        // Atributos ou campos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        public void ExibirInformacao()
        {
            Console.WriteLine($"Seja bem vindo {nome} {sobrenome}, seu ano de nascimento é {anoNascimento}");
        }

    }
}
