<?php

class Student
{
    public $voornaam;
    public $achternaam;
    public $aanwezig = false;

    public function checkAanwezigheid()
    {
        $this->aanwezig = true;
        return "aanwezig";
    }
}