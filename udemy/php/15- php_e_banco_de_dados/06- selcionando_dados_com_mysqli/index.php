<?php

use LDAP\Result;

$host = "localhost";
$user = "alves";
$pass = "1503";
$db = "conexoes";


$conn = new mysqli($host, $user, $pass, $db);

$sql = "SELECT * FROM pessoas";

$result = $conn->query($sql);
$conn->close();

// Um resultado
$item = $result->fetch_assoc();
print_r($item);

echo "<br>";

//Todos os resultados
$itens = $result->fetch_all();
print_r($itens);