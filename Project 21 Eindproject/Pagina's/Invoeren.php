<?php
require "../Classes/Klant.php";
require "../Classes/Sessie.php";

$isAangemaakt = true;


//als er een cookie is aangemaakt stuurt hij de gebruiker gelijk door naar Overview.php.
if (!isset($_COOKIE["eindproject-session"])) {
    header("location: LogInPagina.php");
}

//als de gebruikersnaam bestaat voert hij het volgende uit:
if (isset($_POST["klantvoornaam"])) {

    //hij koppelt de username en password variabelen aan wat er is ingevoerd op de pagina.



    $klant = new Klant();
    $klant->email = $_POST["Email"];
    $klant->adres = $_POST["Adres"];
    $klant->voornaam = $_POST["klantvoornaam"];
    $klant->achternaam = $_POST["klantachternaam"];
    $klant->insert();
    header("location: homePagina.php");
}
?>

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="../CSS/styles.css">

    <title>Invoer pagina</title>
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
        <div class="row">
            <div class="col-3"></div>
            <div class="col-6">
                <form class="p-5" method="post">
                    <div class="mb-3">
                        <h2>Invoeren</h2>
                        <label for="Klantvoornaam" class="form-label">Voornaam van de klant</label>
                        <input type="text" class="form-control" id="klantvoornaam" name="klantvoornaam">
                        <div id="emailHelp" class="form-text">voer hier de voornaam van de klant in</div>
                    </div>
                    <div class="mb-3">
                        <label for="Klantachternaam" class="form-label">Achternaam van de klant</label>
                        <input type="text" class="form-control" id="klantachternaam" name="klantachternaam">
                        <div id="emailHelp" class="form-text">voer hier de achternaam van de klant in</div>
                    </div>
                    <div class="mb-3">
                        <label for="Adres" class="form-label">Adres</label>
                        <input type="text" class="form-control" id="Adres" name="Adres">
                        <div id="emailHelp" class="form-text">Voer hier het adres van de klant in</div>
                    </div>
                    <div class="mb-3">
                        <label for="Email" class="form-label">Email</label>
                        <input type="text" class="form-control" id="Email" name="Email">
                        <div id="emailHelp" class="form-text">Voer hier de email van de klant in</div>
                    </div>
                    <button type="submit" class="btn btn-dark">Bevestig</button>


                </form>
            </div>
        </div>
    </div>

</body>