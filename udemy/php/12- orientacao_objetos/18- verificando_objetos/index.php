<?php

class Humano {

    public function falar() {
        echo "Olá";
    }

}


$henrique = new Humano;
$teste = 10;

if(is_object($henrique)) {
    echo "É um objeto <br>";
} else {
    echo "Não é um objeto<br>";
}


if(is_object($teste)) {
    echo "É um objeto <br>";
} else {
    echo "Não é um objeto<br>";
}

echo get_class($henrique);
echo "<br>";

if (method_exists($henrique, "falar")) {
    echo "O metodo existe <br>";
} else {
    echo "O metodo não existe";
}

if (method_exists($henrique, "asd")) {
    echo "O metodo existe <br>";
} else {
    echo "O metodo não existe";
}