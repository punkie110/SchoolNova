<?php

switch($prijs = 18){
case $prijs >= 30 && $prijs <= 40:
    echo "Duur concert";
    break;
    case $prijs >= 10 && $prijs <= 30:
        echo "Niet te duur/niet te goedkoop";
        break;
        case $prijs >= 10 && $prijs <= 20:
            echo "Goedkoop concert";
            break;
            default: echo "Prijs niet gedefinieerd"; 
        }

?>