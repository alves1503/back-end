<?php

class Pessoa {
    public $nome = "Henrique";


    function saudacao() {
        echo "Ola $this->nome";
    }

}


// Se a classe existe
if (class_exists("Pessoa")) {
    echo "A classe existe <br>";
}

if (class_exists("Cachorro")) {
    echo "A classe existe <br>";
} else {
    echo "A classe não existe <br>";
}


// Propriedades
print_r(get_class_vars("Pessoa"));
echo "<br>";

print_r(get_class_methods("Pessoa"));
