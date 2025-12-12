<?php


$arr = [

    [1, 20, 30 ,40],
    [50 ,25, 70, 55],
    [22, 10, 23, 11]
];


for ($i = 0; $i < count($arr); $i++) {
    for ($j = 0; $j < count($arr[0]); $j++) {
        echo $arr[$i][$j] . ", ";
    }
    echo "Trocou de array! <br>";
}



