<?php


interface Caracteristicas {
    const nome = "Henrique";
    public function falar();
}


class Humano implements Caracteristicas{

    public $idade = 20;

    public function falar()
    {
        echo "Ola mundo <br>";
    }

    public function dizerNome() {
        echo "Meu nome é: " . self::nome;
    }



}


$henrique = new Humano;
$henrique->falar();
$henrique->dizerNome();