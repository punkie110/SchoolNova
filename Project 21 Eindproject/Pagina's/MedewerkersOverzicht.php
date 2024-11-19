<?php
require "../Classes/Gebruiker.php";
require "../Classes/Sessie.php";

//als er een cookie is aangemaakt stuurt hij de gebruiker gelijk door naar Overview.php.
if (!isset($_COOKIE["eindproject-session"])) {
    header("location: LogInPagina.php");
}

//gebruikt de functie om alle gebruikers op te halen. 
$gebruikers = Gebruiker::findAll();
?>

<head>
    <!--De connecties met CSS/Bootstrap-->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" href="../CSS/styles.css">
</head>

<body>
<div class="background"></div>
    <!--De navigatiebalk-->
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
        <div class="container">
            <a class="navbar-brand" href="homePagina.php">
                <img src="../upload/Logo.PNG" alt="Logo" class="img-fluid">
            </a>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <div class="navbar-nav">
                    <a class="nav-link" href="homePagina.php">Home</a>
                    <a class="nav-link" href="concerten.php">Manager Dashboard</a>
                    <a class="nav-link" href="MedewerkersOverzicht.php">Medewerker Overzicht</a>
                    <a class="nav-link" href="Invoeren.php">Voer klant in</a>
                    <a class="nav-link" href="AddReservering.php">Maak een reservering</a>
                    <a href="Logout.php" class="btn btn-dark">Log uit</a>
                </div>
            </div>
        </div>
    </nav>

    <div class="container-fluid" id="container-main">
        <div class="row justify-content-center">
            <?php
            //Als er gebruikers opgehaald kunnen worden gaat hij de foreach loop in om zo alle gebruikers op te halen.
            //Voor elke gebruiker die bestaat in de database maakt hij een kaartje aan met de contents van de gebruiker.
            if (Count($gebruikers) == 0) {
                echo "Er zijn geen medewerkers beschikbaar, probeer er eentje toe te voegen!<br>";
                echo '<a href="Insert.php" class="btn btn-success">Voeg Toe</a>';
            } else {
                foreach ($gebruikers as $gebruiker) {
            ?>
                    <div class="col">
    <div class="card">
        <img src="../upload/<?= $gebruiker->foto; ?>" class="card-img-top" alt="Profielfoto">
        <div class="card-header">
            <h5 class="card-title"><?= $gebruiker->naam ?> <?= $gebruiker->achternaam ?></h5>
        </div>
        <div class="card-body">
            <h5 class="card-body">Gebruikersnaam: <?= $gebruiker->gebruikersnaam ?></h5>
            <h5>Email: <?= $gebruiker->email ?></h5> <br/>
            <a href="MedewerkerWijzigen.php?id=<?= $gebruiker->id; ?>" class="btn btn-primary">Pas Aan</a>
            <a href="MedewerkerVerwijderen.php?id=<?= $gebruiker->id; ?>" class="btn btn-danger">Verwijder</a>
        </div>
    </div>
</div>

            <?php
                }
            }
            ?>
        </div>
        <div class="card" id="addUser">
    <img src="../upload/gebruikertoevoegenremovebg.png" class="card-img-top" alt="Profielfoto">
    <div class="card-header">
        <h5 class="card-title">Voeg een Medewerker Toe!</h5>
    </div>
    <div class="card-body">
        <h5 class="card-body">
            <a href="MedewerkerToevoegen.php" class="btn btn-success">Voeg een medewerker toe</a>
        </h5>
    </div>
</div>
        
    </div>
</body>