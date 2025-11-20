    <?php





    $cont = 10;
    $array = [];


    while ($cont <= 100) {


        $array[$cont] = $cont;
        if ($array[$cont] === 30 || $array[$cont] === 40) {

            echo "Número pulado: " . $array[$cont] . "<br>";
            $cont += 10;
            continue;
        }

        echo $array[$cont] . "<br>";







        $cont += 10;
    }

    echo sizeof($array);
