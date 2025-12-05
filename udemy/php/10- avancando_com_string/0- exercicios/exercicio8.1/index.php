<?php


$strPromo = strtoupper("promocao");
$strSimple = "este item está em $strPromo";
$strFinal = ucfirst($strSimple);

echo $strFinal;
