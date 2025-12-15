<?php



class Carro
{


    public $marca;
    public $ano;
    public $velocidade_maxima;

    function setVelocidadeMaxima($marca, $ano, $velocidade)
    {
        $this->marca = $marca;
        $this->ano = $ano;
        $this->velocidade_maxima = $velocidade;
    }

    function getVelocidadeMaxima() {
        echo "Seu carro '$this->marca' do ano de $this->ano possui velocidade maxima de $this->velocidade_maxima KM/H";
    }
}



$civic = new Carro;
$civic->setVelocidadeMaxima("Civic", 2025, 200);
$civic->getVelocidadeMaxima();
