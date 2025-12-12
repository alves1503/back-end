<?php

$arr = [
'Henrique' => 20,
"Ana" => 10,
"Pedro" => 15,
"Maria" => 8
];


asort($arr);
print_r($arr);
echo "<br>";

$arr2 = [
'Henrique' => 20,
"Ana" => 10,
"Pedro" => 15,
"Maria" => 8
];

arsort($arr2);
print_r($arr2);
echo "<br>";