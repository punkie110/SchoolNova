<?php
class Gadget
{
    public string $type;
    public int $voorraad;
    public int $prijs;

    public function __construct(string $type)
    {
        $this->type = $type;
    }
}

$gadget = new Gadget("");
$gadget->voorraad = 555;
