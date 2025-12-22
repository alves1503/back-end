<?php


$host = "localhost";
$user = "alves";
$pass = "1503";
$db = "conexoes";


$conn = new mysqli($host, $user, $pass, $db);

// CRIA UMA TABELA
/*$sql = "CREATE TABLE animais (
nome VARCHAR(200),
idade INT(200)
);"; */

//Delata a tabela
$d = "DROP TABLE animais";

$conn->query($d);

$conn->close();
