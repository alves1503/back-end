<?php

class Humano
{

    public $nome;
    public $idade;


    function atribuirProp($nome, $idade)
    {
        $this->nome =  $nome;
        $this->idade =  $idade;
    }

    function falar()
    {
        echo $this->nome . " Falou!";
    }
}


class Professor extends Humano
{

    private $disciplina;
    private $escola;


    function atribuirPropProf($disciplina, $escola)
    {
        $this->disciplina =  $disciplina;
        $this->escola =  $escola;
    }


    function exibirInfo() {
        echo "Ola, eu sou $this->nome e tenho $this->idade anos e ensino $this->disciplina na escola de $this->escola";
    }
}



// Professor
$marcos = new Professor;
$marcos->atribuirProp("Marcos", 32); //Atribui o nome e idade
$marcos->atribuirPropProf("Matemática", "Carmo do Cajuru");
$marcos->exibirInfo();
