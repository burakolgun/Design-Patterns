<?php
include './Animal.php';
include './ItFlys.php';
include './CantFlys.php';

$animal = new Animal(new CantFlys);
$animal->fly();