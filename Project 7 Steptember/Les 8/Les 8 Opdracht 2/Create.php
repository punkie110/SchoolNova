<?php
require "Sessie.php";
$key = md5(uniqid(rand(), true));
$sessie = new Sessie();
$sessie->userId = 1;
$sessie->key = $key;
$sessie->start = date("Y-m-d H:i:s");
$sessie->end = date("Y-m-d H:i:s", strtotime("+1 month"));
$sessie->newSessie();

setcookie("steptember-session", $key, strtotime("+1 month"), "/");
