<?php


$host = "localhost";
$db = "conexoes";
$user = "alves";
$pass = "1503";


$conn = new PDO("mysql:host=$host;dbname=$db", $user, $pass);

$id = 3;
$nome = "Nome atualizado";
$idade = 35;

$stmt = $conn->prepare("UPDATE pessoas SET nome = :nome, idade = :idade WHERE id = :id ");
$stmt->bindParam(":id", $id);
$stmt->bindParam(":nome", $nome);
$stmt->bindParam(":idade", $idade);

$stmt->execute();