<?php


class Humano {

}

class Animal {

}

$henrique = new Humano;
$bob = new Animal;

if($henrique instanceof Humano) {
    echo "Henrique é um humano <br>";
}


if($bob instanceof Humano) {
    echo "Henrique é um humano";
} else {
        echo "Bob não é um humano";
}
