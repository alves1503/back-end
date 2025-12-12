<?php



$arr = [
    'nome' => 'Henrique', 
    'idade' => 20
];


if(array_key_exists("nome", $arr)) {
    echo "A chave existe! <br>";
} else {
    echo "A chave não existe! <br>";
}


if(array_key_exists("teste", $arr)) {
    echo "A chave existe! <br>";
} else {
    echo "A chave não existe! <br>";
}



// Isset
if(isset($arr['nome'])) {
      echo "A chave existe! <br>";
} else {
    echo "A chave não existe! <br>";
}