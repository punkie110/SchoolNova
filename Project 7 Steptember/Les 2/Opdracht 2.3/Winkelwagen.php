<?php
class winkelwagen
{
    public string $naam;
    public float $totaalBedrag = 0;
    public int $aantalProducten = 0;

    function voegProductToe($product, $prijs, $hoeveelheid)
    {
        $this->totaalBedrag +=  $prijs * $hoeveelheid;
        $this->aantalProducten += $hoeveelheid;
    }
    function totaalBedrag()
    {
        return "je totaalbedrag is " . $this->totaalBedrag . "<br />" . "Je totaal aantal producten zijn " . $this->aantalProducten;
    }
}
