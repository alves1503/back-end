<?php

$arr1 = [10, 20, 30];
$arr2 = [20, 20, 30];
$arr3 = [10, 20, 40];


$arrMerge = array_merge($arr1, $arr2, $arr3);
print_r($arrMerge);