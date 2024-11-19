<?php
$studenten = array("Daniel", "Sara", "Rajeed", "Rick");
$cijfers = array(6.5, 8, 7, 4.5);
for ($i = 0; $i < count($studenten); $i++ )
{
echo "$studenten[$i] heeft een $cijfers[$i] behaald. <br />";
}

?>