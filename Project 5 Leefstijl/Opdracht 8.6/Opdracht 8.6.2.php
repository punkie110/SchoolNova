<?php
$prijs = 0;
if (array_key_exists("Pizza_Margherita", $_POST)) 
{
    $prijs += 9;
}
if (array_key_exists("Pizza_Salami", $_POST))
{
    $prijs += 11;
}
if (array_key_exists("Pizza_Stagioni", $_POST))
{
$prijs += 15;
}
echo "U moet $prijs betalen."
?>