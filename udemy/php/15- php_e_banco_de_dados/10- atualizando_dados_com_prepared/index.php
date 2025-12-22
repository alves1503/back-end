<?php


$host = "localhost";
$user = "alves";
$pass = "1503";
$db = "conexoes";

$conn = new mysqli($host, $user, $pass, $db);


$id = 2;

$stmt = $conn->prepare("UPDATE pessoas SET nome = ?, idade = ? WHERE id = ?");


$nome = "Jane Alves";
$idade = 50;

$stmt->bind_param("sii", $nome, $idade, $id);

$stmt->execute();

if($stmt->error) {
    echo "Erro: " . $stmt->error;
}