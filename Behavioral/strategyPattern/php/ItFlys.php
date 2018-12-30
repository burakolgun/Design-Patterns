<?php

include './Flys.php';

class ItFlys implements Flys
{
    public function fly()
    {
        echo ('Can Fly!');
    }
}