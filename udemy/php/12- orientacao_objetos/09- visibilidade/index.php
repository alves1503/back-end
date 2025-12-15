<?php


class Car {
    
    public $rodas = 4;
    private $vidro = "Sem película";
    protected $portas = 4;

    public function getVidro() {
        return $this->vidro;
    }

}

class Mecanico {

    public function alterarRodas($carro) {
        $carro->rodas = 10;
    }

    public function colocarPelicula($carro, $pelicula) {
        $carro->vidro = $pelicula;

}
}

$carro = new Car;

echo $carro->rodas . "<br>";

$henrique = new Mecanico;
$henrique->alterarRodas($carro);

echo $carro->rodas . "<br>";

// Não pode alterar pois é privado
//$henrique->colocarPelicula($carro, "G20");
echo $carro->getVidro();
