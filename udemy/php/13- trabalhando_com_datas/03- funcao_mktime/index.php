<?php

$dataNascimento = mktime(02,00,00,03,15,2005);
echo $dataNascimento . "<br>"; 

$dataNascimentoFormatada = date('d/m/Y', $dataNascimento);
echo $dataNascimentoFormatada . "<br>"; 