<?php




function teste($a, $b)
{

    print_r(func_get_args());
    echo "<br>";
    echo (func_num_args());
    return $a + $b;
}

teste(2,5);