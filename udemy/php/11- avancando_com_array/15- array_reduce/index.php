<?php

$arr = [1, 2, 4, 20, 20];

function soma($a, $b) {
    return $a + $b;
}


$resultado = array_reduce($arr, "soma");

echo "$resultado <br>";