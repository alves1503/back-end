<?php


if(isset($_POST['ingredientes'])) {
    $ingredientes = $_POST['ingredientes'];
    print_r($ingredientes);
}

?>
<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>


    <form action="index.php" method="post">

        <div>
            <input type="checkbox" name="ingredientes[]" value="Tomate"> Tomate
        </div>

        <div>
            <input type="checkbox" name="ingredientes[]" value="Alface"> Alface
        </div>

        <div>
            <input type="checkbox" name="ingredientes[]" value="Arroz"> Arroz
        </div>

        <div>
            <input type="submit" value="Enviar">
        </div>

    </form>

</body>

</html>