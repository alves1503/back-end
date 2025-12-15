<?php


abstract class Teste {
    public static function testandoClasse() {
        echo "Este métodos é uma classe abstrata <br>";
    }

    abstract public function testeAbs();
}


Teste::testandoClasse();

class Nova extends Teste {
    public function testeAbs()
    {
         echo "Teste método abstrato <br>";
    }
}

$n = new Nova;
$n->testeAbs();