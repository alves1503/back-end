using System.Globalization;
using ExemploExplorando.models;




Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("MG", "Minas Gerais");
estados.Add("SP", "São Paulo");

estados["SP"] = "São Paulo valor alterado";


foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} e o valor: {item.Value}");
}


estados.Remove("SP");
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} e o valor: {item.Value}");
}



















/* Stack<int> pilha = new Stack<int>();

pilha.Push(5);
pilha.Push(57);
pilha.Push(50);


foreach (int i in pilha)
{
    Console.WriteLine(i);
}


Console.WriteLine($"Item da pilha removida {pilha.Pop()}");


foreach (int i in pilha)
{
    Console.WriteLine(i);
}

 */





/* Queue<int> fila = new Queue<int>();

fila.Enqueue(2); //Adiciona o elemnto ao final da fila

fila.Enqueue(3);

fila.Enqueue(8);

fila.Enqueue(9);


foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");



 */











/* 
try
{


    string[] linhas = File.ReadAllLines("arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
}

finally 
{
    Console.WriteLine($"Chegou ate aqui");
}






 */




























/* string dataString = "2022-13-17 18:00";




bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso da data {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data valida");
} */





















/* Pessoa p1 = new Pessoa("Henrique", "Alves");


Pessoa p2 = new Pessoa("Ana", "Maria");


double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));



Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Ingês";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionrAluno(p1);
CursoDeIngles.AdicionrAluno(p2);
CursoDeIngles.ListarAlunos();

int numero = 123456;

Console.WriteLine(numero.ToString("##-##-##"));






 */





/* p1.Nome = "Henrique";
p1.Sobrenome = "Alves";
p1.Idade = 20   ;
p1.Apresentar(); */