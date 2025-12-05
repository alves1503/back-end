<?php



$textoHtml = "<p>Testando paragrafo</p> <div>Esta é uma div!</div> <p>Outro paragrafo</p> <br>";


echo $textoHtml;

$salvarTextoBanco = strip_tags($textoHtml);
echo $salvarTextoBanco;

