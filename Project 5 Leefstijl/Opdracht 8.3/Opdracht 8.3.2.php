<?php
$rang = $_POST["rang"];
$stuks = $_POST["stuks"];
$korting = $_POST["korting"];
$totalePrijs = 0;
if($rang == "A")
{
$totalePrijs = 80 * $stuks;
}
else if($rang == "B")
{
$totalePrijs = 50 * $stuks;

}
else if($rang == "C")
{
$totalePrijs = 40 * $stuks;
}
if($korting == "ja")
{
    $totalePrijs *= 0.8;
} 
echo "De totale prijs is $totalePrijs"
?> 