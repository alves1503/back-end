<?php


$arr1 = [1, 5, 10]; //Diferença o '5'
$arr2 = [1 ,10, 10];

$diff = array_diff($arr1, $arr2);
print_r($diff);