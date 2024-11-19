<?php
require_once "../Classes/Sessie.php";

if (isset($_COOKIE["eindproject-session"])) {
    // Haal de huidige sessie op uit de database
    $sessie = Sessie::getSession($_COOKIE["eindproject-session"]);

    // Verwijder de sessie uit de database
    $sessie->deleteSession();

    // Verwijder de sessiecookie
    setcookie("eindproject-session", "", time() - 3600, "/");

    // Redirect naar de login pagina
    header("location: LogInPagina.php");
    exit();
} else {
    // Als er geen sessie is, redirect naar de login pagina
    header("location: LogInPagina.php");
    exit();
}
