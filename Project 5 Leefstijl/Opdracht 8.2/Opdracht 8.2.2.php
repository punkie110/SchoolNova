<?php
try {

$input = $_POST["input"];
$percentage = $_POST["percentage"];
if($percentage == "10%")
{
$input *= 1.10;
echo "De verkoopprijs is $input";
}
else if($percentage == "15%")
{
$input *= 1.15;
echo "De verkoopprijs is $input";
}
} catch (\Throwable $th) 
{

}



?>