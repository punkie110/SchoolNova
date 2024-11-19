<?php
require "Sessie.php";
require "Gebruiker.php";

$isAangemaakt = true;

//als er een cookie is aangemaakt stuurt hij de gebruiker gelijk door naar Overview.php.
if (isset($_COOKIE["steptember-session"])) {
    header("location: Overview.php");
}

//als de gebruikersnaam bestaat voert hij het volgende uit:
if (isset($_POST["gebruikersnaam"])) {

    //hij koppelt de username en password variabelen aan wat er is ingevoerd op de pagina.
    $username = $_POST["gebruikersnaam"];
    $password = $_POST["wachtwoord"];

    //die username en password neemt hij mee in de checkuser functie.
    // Hij kijkt dus of deze gebruiker bestaat en haalt de gegevens van de gebruiker op.
    $gebruiker = Gebruiker::checkUser($username, $password);

    //als gebruiker null is is de boolean isAangemaakt false wat dus betekent dat de gebruiker niet bestaat.
    if ($gebruiker == null) {
        $isAangemaakt = false;
    
//anders maakt hij een nieuwe cookie aan waar het ID van de gebruiker ook wordt meegegeven. 
// vervolgens stuurt hij de gebruiker naar Overview.php.
    } else {


        $key = md5(uniqid(rand(), true));
        $sessie = new Sessie();
        $sessie->userId = $gebruiker->id;
        $sessie->key = $key;
        $sessie->start = date("Y-m-d H:i:s");
        $sessie->end = date("Y-m-d H:i:s", strtotime("+1 month"));
        $sessie->newSessie();

        setcookie("steptember-session", $key, strtotime("+1 month"), "/");

        header("location: Overview.php");
    }
}
?>

<!-- De inlogpagina, in head maakt hij de titel aan en de connectie met bootstrap.-->
<head>
    <meta charset="UTF-8">
    <title>Project Steptember</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>

<!-- De body, hierin wordt het inlog form aangemaakt en hier kan je dus het gebruikersnaam en wachtwoord invullen. -->
<body>
    <div class="container-fluid text-center" id="containerMain">
        <div class="row row-justify-content-center" id="onderHeader">
            <div class="Steptember-afbeelding" id="afbeelding">

                <img src="Images/ProjectSteptember.png" alt="Steptember logo">

            </div>
        </div>

        <form name="Inloggen" method="post">
            <h5>gebruikersnaam:</h5>
            <input type="text" name="gebruikersnaam"><br />
            <h5>wachtwoord:</h5>
            <input type="text" name="wachtwoord"><br />
            <input type="submit" value="Bevestigen">

            <?php
            //als de boolean isAangemaakt false is (wat hierboven wordt gecontroleerd) 
            //geeft hij de foutmelding dat je gebruikersnaam of wachtwoord onjuist is.
            if (!$isAangemaakt) {
                echo "<br /> Je gebruikersnaam of wachtwoord zijn onjuist.";
            }

            ?>
    </div>
</body>

<!-- Een footer die de pagina mooi afsluit. -->
<div class="container" id="footer">
    <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
        <div class="col-md-4 d-flex align-items-center">
            <span class="mb-3 mb-md-0 text-muted">© 2023 Steptember, Inc</span>
        </div>
    </footer>