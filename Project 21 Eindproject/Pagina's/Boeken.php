<?php
require "../Classes/Gebruiker.php";
require "../Classes/Sessie.php";
require "../Classes/Plaatsen.php";
require "../Classes/Klant.php";
require "../Classes/Reservering.php";

if (isset($_POST["aankomstdatum"])) {

    $reservering = new Reservering();
    $reservering->klantnummer = $_POST["naam"];
    $reservering->plaats = $plek->id;
    $reservering->aankomstdatum = $_POST["aankomstdatum"];
    $reservering->vertrekdatum = $_POST["vertrekdatum"];
    $reservering->insert();
    header("location: homePagina.php");
}

if (isset($_COOKIE["eindproject-session"])) {

    $sessie = Sessie::getThisSession();
    $gebruiker = Gebruiker::findById($sessie->id);
} else {
    header("location: LogInPagina.php");
}
$id = $_GET['id'];
$plek = Plaats::findById($id);

$klanten = Klant::findAll();

$reserveringen = Reservering::findAllByPlaats($id);

$booked = [];
foreach ($reserveringen as $reservering) {
    $booked[] = [
        'start' => date('Y-m-d', strtotime($reservering->aankomstdatum)),
        'end' => date('Y-m-d', strtotime($reservering->vertrekdatum))
    ];
}


if (empty($reserveringen)) {
    $reserveringen = []; // Zorg ervoor dat het een lege array is als er geen reserveringen zijn
}

if (count($klanten) > 0) {
?>
    <script>
        // Boekingsdata doorgegeven vanuit PHP naar JavaScript
        var bookedRanges = <?php echo json_encode($booked); ?>;
    </script>
    <!DOCTYPE html>
    <html lang="nl">

    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <script src="https://code.jquery.com/jquery-3.7.1.js"></script>
        <script src="../jquery-ui.min.js"></script>
        <script src="../CSS/script.js"></script>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
        <title>Interactieve Afbeelding</title>
        <link rel="stylesheet" href="../jquery-ui.min.css">
        <link rel="stylesheet" href="../CSS/styles.css">
    </head>

    <body>
        <div class="background"></div>
        <!--De navigatiebalk-->
        <nav class="navbar navbar-expand-lg">
            <div class="container">
                <a class="navbar-brand" href="homePagina.php">
                    <img src="../upload/Logo.PNG" alt="Logo" class="img-fluid">
                </a>
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
            </div>
        </nav>
        <div class="container-fluid" id="container-main">
            <div class="row">
                <div class="image-container">
                    <h1>plek <?= $plek->id ?></h1>
                    <h1>€<?= $plek->prijs ?>,--</h1>
                </div>
                <div class="dropdown">
                    <button class="btn btn-secondary dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">
                        Klant
                    </button>

                    <form method="POST">
                        <ul class="dropdown-menu">
                            <?php

                            foreach ($klanten as $klant) {
                            ?>
                                <li><a class="dropdown-item klant-select" rel="<?= $klant->id; ?>" id="klantnaam" href="#"><?= $klant->voornaam ?> <?= $klant->achternaam ?></a></li>
                            <?php
                            } ?>
                        </ul>
                        <input type="hidden" name="klantnummer" id="klantnummer">
                        <div id="selectedKlant"></div>

                        <div class="btn-group" role="group" aria-label="Opties">
                            <input type="checkbox" class="btn-check" id="btncheck1" autocomplete="off">
                            <label class="btn btn-outline-primary custom-btn" for="btncheck1">Wasmachine (€6,00.-- Per dag)</label>

                            <input type="checkbox" class="btn-check" id="btncheck2" autocomplete="off">
                            <label class="btn btn-outline-primary custom-btn" for="btncheck2">Droger (€4,00.-- per dag)</label>

                            <input type="checkbox" class="btn-check" id="btncheck3" autocomplete="off">
                            <label class="btn btn-outline-primary custom-btn" for="btncheck3">Hond (€2,00.-- Per dag)</label>
                        </div>

                        <p>Aankomstdatum: <input type="text" id="aankomstdatum"></p>
                        <p>Vertrekdatum: <input type="text" id="vertrekdatum"></p>

                        <input type="submit" class="btn-check" id="btnconfirm">
                        <label class="btn btn-outline-primary custom-btn" for="btnconfirm">Boeken</label>

                    </form>
                </div>
            </div>
        </div>
        <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.min.js" integrity="sha384-0pUGZvbkm6XF6gxjEnlmuGrJXVbNuzT9qBBavbLwCsOGabYfZo0T0to5eqruptLy" crossorigin="anonymous"></script>

    <?php
} else {
    echo "Er staan geen klanten in de database.";
}
    ?>
    </div>
    </body>