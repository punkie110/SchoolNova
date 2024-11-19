<?php
$keuze = $_POST["stuks"];

if($keuze == "4Stuks")
{
   $code = rand(1000, 9999);
   echo "Jouw wachtwoord is $code";
}
else if($keuze == "5Stuks")
{
    $code = rand(10000, 99999);
    echo "Jouw wachtwoord is $code";
}
else if($keuze == "6Stuks")
{
    $code = rand(100000, 999999);
    echo "Jouw wachtwoord is $code";
}


?>