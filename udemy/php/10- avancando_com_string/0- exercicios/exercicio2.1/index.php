<?php



$arr = [


    'porta' => 100,
    'macaneta' => 10,
    'retrovisor' => 11




];


function retornePreco($arr)
{


    $arrItensCaros = [];


    foreach($arr as $item => $preco) {



        if ($preco > 10) {
            array_push($arrItensCaros, $item);
        }
    }


    return $arrItensCaros;
    
}


$novoArray = retornePreco($arr);


print_r ($novoArray);
