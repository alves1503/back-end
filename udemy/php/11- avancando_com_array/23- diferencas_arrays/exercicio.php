<?php

$arr = [10, 0, 50, 55, 11, 22];



function ordenarNumeros($array) {

    sort($array);
    

    return $array;

}


print_r(ordenarNumeros($arr));