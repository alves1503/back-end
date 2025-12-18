<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trabalhando com POST</title>
</head>

<body>


    <form action="cadastro.php" method="post">
        <div>
            <input type="text" name="usuario" placeholder="Seu usuario">
        </div>

        <div>
            <input type="email" name="email" placeholder="Seu e-mail">
        </div>

        
        
        <div>
            <input type="checkbox" name="opcionais[]" value="Homem"> Homem
        </div>


        <div>
            <input type="checkbox" name="opcionais[]" value="Mulher"> Mulher
        </div>


        <div>
            <input type="checkbox" name="opcionais[]" value="Maior de idade"> Maior de idade
        </div>


        <div>
            <input type="checkbox" name="opcionais[]" value="Menor de idade"> Menor de idade
        </div>
        
        
        <div>
         <input type="submit" value="Enviar">
     </div>
    </form>

</body>

</html>