<?php
class gebruiker
{
    public string $voornaam;
    public string $achternaam;
    public string $emailAdres;
    function geefVolledigeNaam()
    {
        return $this->voornaam . " " . $this->achternaam . "<br />" . $this->emailAdres . "<br />";
    }
}
