<?php

$method = $_SERVER['REQUEST_METHOD'];
if(isset($_POST['nome'])) {
    $nome = $_POST['nome'];
}


?>

<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Autoprocessamento</title>
</head>

<body>

<?php
if ($method == 'GET'): 
?>

    <form action="index.php" method="post">
        <input type="text" name="nome" placeholder="Seu nome"> <br>
        <input type="submit" value="Enviar">
    </form>

    <?php 
else: ?>
<h1>O seu nome é <?= $nome ?></h1>
<?php endif;?>

</body>

</html>