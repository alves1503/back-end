using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExemploExplorando.models
{
    public class Curso
    {
        //Propriedade Nome
        public string Nome { get; set; }

        //Propriedade do tipo e lista
        public List<Pessoa> Alunos { get; set; }


        //Método vazio "void"
        public void AdicionrAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        //Metodo do tipo Inteiro
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count; //Variavel para pegar a quantidade de alunos matriculados
            return quantidade; //Vai retornar a quantidade
        }


        //Metodo para remover alunos
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        //Metodo para listar alunos
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}