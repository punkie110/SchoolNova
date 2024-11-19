<?php
class Product
{
public string $naam;
public int $voorraad;
public float $prijs;

public function omschrijf()
{
    return $this->naam . ":" . " vooraad = " . $this->voorraad . " prijs = " . $this->prijs . "<br />";
}
}
?>