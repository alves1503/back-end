<?php

class Cachorro {


    function latir() {
        echo "O cachorro latiu <br>";
    }

    function andar() {
        echo "O cachorro andou <br>";
    }

}



$bob = new Cachorro;
$bob->latir();
$bob->andar();