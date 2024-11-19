<?php
for($i = 0; $i < 10001; $i++)
{
$key = md5(uniqid(rand(), true));
echo $key . "<br />";
}
?>