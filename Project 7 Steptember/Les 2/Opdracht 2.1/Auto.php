<?php
class Auto
{
    public string $merk;
    public string $model;
    public int $bouwjaar;
    public float $waarde;
    function info()
    {
        return $this->merk . "<br />" . $this->model . "<br />" . $this->bouwjaar . "<br />" . $this->waarde . "<br />";
    }
    function verkoop($verkoopprijs)
    {
        if ($verkoopprijs < $this->waarde) {
            return $this->info() . " auto wordt niet verkocht. <br /> <br />";
        } else {
            return $this->info() . " auto is verkocht. <br /> <br />";
        }
    }
}
