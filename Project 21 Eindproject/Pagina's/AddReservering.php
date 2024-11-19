<?php
require "../Classes/Gebruiker.php";
require "../Classes/Sessie.php";
require "../Classes/Plaatsen.php";
if (isset($_COOKIE["eindproject-session"])) {

    $sessie = Sessie::getThisSession();
    $gebruiker = Gebruiker::findById($sessie->id);
} else {
    header("location: LogInPagina.php");
}
$plekken = Plaats::findAll();
// Verwerk de POST-aanroep alleen als deze plaatsvindt
if (isset($_GET["id"])) {
    $id = $_GET['id'];
    $plek = Plaats::findById($id);
    // Verwerk de ontvangen gegevens, bijv. opslaan in de database
?>
    <div>
        <?php if ($plek->type == "Plek voor Camper") { ?>
            <img src="../Upload/campeerplekcamper.jpg">
        <?php } else if ($plek->type == "Plek voor Tent") { ?>
            <img src="../Upload/tent plek.jpg">
        <?php } else { ?>
            <img src="../Upload/stroomvoorziening.jpg">
        <?php } ?>
    </div>
    <div>
        <h1>Plek <?= $id; ?></h1>
        <h1><?= $plek->type ?></h1>
    </div>
    <div>
        <h2>€<?= $plek->prijs ?></h2>
        <a href="Boeken.php?id=<?= $plek->id; ?>" class="btn btn-primary">Boeken </a>
    </div>

<?php

    exit; // Zorg ervoor dat je hier stopt zodat de HTML niet meer wordt weergegeven
}
?>
<!DOCTYPE html>
<html lang="nl">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="https://code.jquery.com/jquery-3.7.1.js"></script>
    <script src="../jquery-ui.min.js"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <title>Interactieve Afbeelding</title>
    <link rel="stylesheet" href="../jquery-ui.min.css">
    <link rel="stylesheet" href="../CSS/styles.css">
</head>

<body>
    <div class="container-fluid">
        <div class="row">
            <nav class="navbar navbar-expand-lg bg-body-tertiary">

                <a class="navbar-brand" href="homePagina.php"><img src="../upload/Logo.PNG" alt="Logo" class="img-fluid"></a>


                <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                    <div class="navbar-nav">
                        <a class="nav-link" href="homePagina.php">Home</a>
                        <?php if ($gebruiker != null && $gebruiker->admin == 1) { ?>
                            <a class="nav-link" href="concerten.php">Manager Dashboard</a>
                            <a class="nav-link" href="MedewerkersOverzicht.php">Medewerker Overzicht</a>
                        <?php } ?>

                        <a class="nav-link" href="Invoeren.php">Voer klant in</a>
                        <a class="nav-link" href="AddReservering.php">Maak een reservering</a>
                        <a href="Logout.php" class="btn btn-dark">Log uit</a>
                    </div>
                </div>
            </nav>
        </div>

        <div class="row">
            <div class="image-container">
                <img src="../Upload/larustigue.jfif" alt="Interactieve Afbeelding" />
                <?php
           
             foreach ($plekken as $plek) {
          ?>
              <div class="square" data-id="<?= $plek->id ?>" 
                   style="top: <?= $plek->top ?>%; left: <?= $plek->left ?>%; transform: rotate(<?= $plek->rotation ?>deg);">
                  <?= $plek->id ?>
              </div>
          <?php
             }
          ?>
        </div>
    </div>
    <script src="../CSS/script.js"></script>
    <div id="dialog" title="Reserveren">

        <div id="result"></div>
    </div>
</body>

</html>