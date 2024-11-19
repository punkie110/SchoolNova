<?php
$voornamen = array("Brandon", "Pieter", "Senna");
$achternamen = array("Smith", "de Boer", "Stal");
$leeftijden = array(18, 24, 16);
for($i = 0; $i < count($voornamen); $i++)
{
    echo "$voornamen[$i] $achternamen[$i]: $leeftijden[$i] jaar oud. <br/>";
}


?>