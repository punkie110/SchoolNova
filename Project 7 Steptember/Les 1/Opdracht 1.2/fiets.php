<?php
class fiets
{
public string $type;
public bool $elektrisch;
public float $bandenspanning;
public string $merk;

public function rijden($bandenspanning)
{
if($bandenspanning >= 3.5 && $bandenspanning <= 4.5)
{
    return "je gaat fietsen!";
}
else
{
return "je bandenspanning is niet goed";
}
}
public function elektrisch($elektrisch)
{
    if($elektrisch == true)
    {
        return "Gefeliciteerd, jouw fiets is elektrisch!";
    }
}
}
?>