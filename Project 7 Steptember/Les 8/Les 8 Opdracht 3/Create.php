<?php
require "Sessie.php";
require "Gebruiker.php";
$gebruikers = Gebruiker::checkUser($username, $password);

$key = md5(uniqid(rand(), true));
$sessie = new Sessie();
$sessie->userId = $gebruikers->id;
$sessie->key = $key;
$sessie->start = date("Y-m-d H:i:s");
$sessie->end = date("Y-m-d H:i:s", strtotime("+1 month"));
$sessie->newSessie();

setcookie("steptember-session", $key, strtotime("+1 month"), "/");
if ($gebruiker = null) {
    header("location: Form.php");
} else {
    header("location: check.php");
}
