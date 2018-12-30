<?php

class Animal
{
    private $name;
    private $age;

    private $strategy;
    function __construct($strategy) {
        $this->strategy = $strategy;
    }

    public function fly()
    {
        $this->strategy->fly();
    }
}