<?php
$beltegoed = 10; 
if($beltegoed == 0)
{
    echo "je beltegoed is op";
}
elseif($beltegoed > 0 && $beltegoed < 10)
{
    echo "je beltegoed moet opgewaardeerd worden";
}
elseif($beltegoed >= 10)
{
    echo "je hebt nog genoeg beltegoed";
}
?>
