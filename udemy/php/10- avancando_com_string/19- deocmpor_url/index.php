<?php


$str = "https://www.google.com.br";;
$arrayUrl = parse_url($str);

print_r($arrayUrl);
echo "<br>";


echo $arrayUrl["host"];
