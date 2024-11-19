<?php
$geld = 8000;
$huisprijs = 200000;
$tekort = $huisprijs - $geld;
if($tekort <= 5000)
{
    echo "Het contract komt eraan";
}
elseif($tekort <= 50000)
{
    echo "With a little help of your friends";
}
elseif($tekort <= 75000)
{
    echo "Dringend opslag vragen";
}
else
{
    echo "Huur een caravan";
}
echo " Je komt ", $tekort, " euro te kort";
?>