<?php
$fahrenheit = $_POST["temperatuur"] * 1.8 + 32;
echo "Het is $fahrenheit Graden Fahrenheit. ";
if($fahrenheit < 32)
{
    echo "Het vriest, doe je jas aan als je naar buiten gaat";
}
else if($fahrenheit >= 70)
{
    echo "Ga mee naar buiten, het is heerlijk weer";
}
else
{
 echo "Lekker weer om binnen een kop thee te drinken.";
}



?>