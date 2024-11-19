<?php
require "../Classes/Gebruiker.php";
require "../Classes/Sessie.php";

$isAangemaakt = true;


//als er een cookie is aangemaakt stuurt hij de gebruiker gelijk door naar Overview.php.
if (isset($_COOKIE["eindproject-session"])) {
    header("location: homePagina.php");
}

//als de gebruikersnaam bestaat voert hij het volgende uit:
if (isset($_POST["gebruikersnaam"])) {

    //hij koppelt de username en password variabelen aan wat er is ingevoerd op de pagina.
    $username = $_POST["gebruikersnaam"];
    $password = $_POST["wachtwoord"];

    //die username en password neemt hij mee in de checkuser functie.
    // Hij kijkt dus of deze gebruiker bestaat en haalt de gegevens van de gebruiker op.
    $gebruiker = Gebruiker::findByUsernameAndPassword($username, $password);
    //als gebruiker null is is de boolean isAangemaakt false wat dus betekent dat de gebruiker niet bestaat.
    if ($gebruiker == null) {
        $isAangemaakt = false;
        //anders maakt hij een nieuwe cookie aan waar het ID van de gebruiker ook wordt meegegeven. 
        // vervolg  ens stuurt hij de gebruiker naar Overview.php.
    } else {


        $key = md5(uniqid(rand(), true));
        $sessie = new Sessie();
        $sessie->userId = $gebruiker->id;
        $sessie->key = $key;
        $sessie->start = date("Y-m-d H:i:s");
        $sessie->end = date("Y-m-d H:i:s", strtotime("+1 month"));
        $sessie->newSessie();

        setcookie("eindproject-session", $key, strtotime("+1 month"), "/");

        header("location: homePagina.php");
    }
}
?>









<!DOCTYPE html>
<html lang="nl">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="../css/styles.css">

    <title>Inlog pagina</title>
</head>


<body>
    <div class="container-fluid" id="login"> <!-- Gebruik container-fluid voor volledige breedte -->
        <div class="row align-items-center" style="height: 100vh;"> <!-- Zorg ervoor dat de rij de volledige hoogte van het venster in beslag neemt -->
            <div class="col-3"></div>
            <div class="col-6">
                <div class="form-container">
                    <form class="p-5" method="post">
                        <div class="mb-3">
                            <h2>log in</h2>
                            <label for="gebruikersnaam" class="form-label">gebruikersnaam</label>
                            <input type="text" class="form-control" id="gebruikersnaam" name="gebruikersnaam" required>
                            <div id="emailHelp" class="form-text">voer uw gebruikersnaam in</div>
                        </div>
                        <div class="mb-3">
                            <label for="wachtwoord" class="form-label">wachtwoord</label>
                            <input type="password" class="form-control" id="wachtwoord" name="wachtwoord" required>
                            <div id="emailHelp" class="form-text">voer uw wachtwoord in</div>
                        </div>
                        <button type="submit" class="btn btn-dark">log in</button>
                    </form>
                </div>
                <?php
                if (!$isAangemaakt) {
                    echo "<br /> Je gebruikersnaam of wachtwoord zijn onjuist.";
                }
                ?>
            </div>
        </div>
    </div>
</body>

</html>