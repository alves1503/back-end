<?php 


$arr = [
'nome' => 'Henrique',
'idade' => 20,
'profissao' => 'Estudande e CLT',
'hobby' => 'Programação'
];



if ($arr['idade'] >= 18) {
    echo "Acesso permitido " . $arr['nome'] . ", você é maior de idade!";
} else {
    echo "Acesso negado" . $arr['nome'] . ", você é menor de idade";
}



?>