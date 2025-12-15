<?php

class Passenger {

    private $name;
    private $age;
    private $seatNumber;


    function __construct($name, $age, $seatNumber)
    {
        $this->name = $name;
        $this->age = $age;
        $this->seatNumber = $seatNumber;
    }

    public function getName() {
        return $this->name;
    } 

    public function getAge() {
        return $this->age;
    }

    public function getSeatNumber() {
        return $this->seatNumber;
    }


    public function setSeatNumber ($seatNumber) {
        $this->seatNumber = $seatNumber;
    }

}

$passageiro1 = new Passenger("Henrique", 20, 15);
echo $passageiro1->getName() . "<br>";
echo $passageiro1->getAge() . "<br>";
echo $passageiro1->getSeatNumber() . "<br>";

$passageiro1->setSeatNumber(35);
echo $passageiro1->getSeatNumber() . "<br>";