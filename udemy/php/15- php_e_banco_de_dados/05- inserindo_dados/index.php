<?php


$host = "localhost";
$user = "alves";
$pass = "1503";
$db = "conexoes";


$conn = new mysqli($host, $user, $pass, $db);

$table = "pessoas";
$nome = "Geraldo Marcelo";
$idade = 60;

$sql = "INSERT INTO $table (nome,idade) VALUES ('$nome', '$idade')";
$conn->query($sql);


$conn->close();