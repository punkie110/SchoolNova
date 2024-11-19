<?php
class boek
{
    public string $titel;
    public string $auteur;
    public int $paginas;
    function lees($huidigepagina)
    {
        if ($huidigepagina > $this->paginas) {
            return false;
        } else {
            return true;
        }
    }
}

