<?php


$host = "localhost";
$user = "alves";
$pass = "1503";
$db = "conexoes";

$conn = new mysqli($host, $user, $pass, $db);

$stmt = $conn->prepare("DELETE FROM pessoas WHERE nome = ?");

$nome = "Mateus";

$stmt->bind_param("s", $nome);

$stmt->execute();
$conn->close();
