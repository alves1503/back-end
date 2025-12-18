<?php


print_r($_SERVER);

echo $_SERVER['MSQL_HOME']  . "<br>";

if ($_SERVER['SERVER_NAME'] == 'localost') {
    echo "Esta acessando o localhost";
} else {
    echo "Esta acessando o localhost";
}
