<?php



$str = "O rato roeu a roupa do rei de roma";

$contStr = 0;

for ($i = 0; $i < strlen($str); $i++) {
    if ($str[$i] === "a") {
        $contStr++;
    }
}

echo "A quantidade de 'a' na frase ($str) é " . $contStr;