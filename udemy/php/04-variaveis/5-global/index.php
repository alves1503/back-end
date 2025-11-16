<?php 


$name = "Henrique";
echo $name;
echo "<br>";
$name = "Ana";
echo $name;
echo "<br>";



function funcao() {
    global $name;
    echo "Ola $name";
}


funcao();
?>