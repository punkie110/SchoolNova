<?php
require "../Classes/Gebruiker.php";
require "../Classes/Sessie.php";
$sessie = Sessie::vindSessies();

//Als de cookie niet bestaat, stuurt hij de gebruiker terug naar de login pagina.
if ($sessie == null) {
    header("location: LogInPagina.php");
    exit;
}
//Als het ID niet geset is, leid het programma je weer terug naar de Admin pagina.
if (!isset($_GET["id"])) {
    header("location: homePagina.php");
    exit;
}

//Haalt de blog op Door middel van het ID, als dat niet lukt leid het programma je weer terug naar de Admin pagina.
$gebruiker = Gebruiker::findById($_GET["id"]);
if ($gebruiker == null) {
    header("location: homePagina.php");
    exit;
}

if (isset($_POST["delete"])) {
    if ($_POST["delete"] == "ja") {
        $gebruiker->delete();
        header("location: MedewerkersOverzicht.php");
    } else {
        header("location: MedewerkersOverzicht.php");
    }
}
?>


<head>
    <!--De connecties met CSS/Bootstrap-->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" href="../Css/admin.css">
</head>

<body>
    <!--De navigatiebalk-->
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
        <div class="container">
            <a class="navbar-brand" href="homePagina.php"><img src="../upload/Logo.PNG" alt="Logo" class="img-fluid"></a>


            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <div class="navbar-nav">
                    <a class="nav-link" href="homePagina.php">Home</a>
                    <a class="nav-link" href="concerten.php">Manager Dashboard</a>
                    <a class="nav-link" href="MedewerkersOverzicht.php">Medewerker Overzicht</a>
                    <a class="nav-link" href="Invoeren.php">Voer klant in</a>
                    <a class="nav-link" href="AddReservering.php">Maak een reservering</a>
                    <a href="Logout.php" class="btn btn-dark">Log uit</a>
                </div>
    </nav>
    <!--De hoofdcontainer-->
    <div class="container-fluid" id="container-main">

        <div class="row row-justify-content-center">
            <h1>Gebruiker Toevoegen</h1>
            <!--De hoofdcontainer-->
    <div class="container-fluid text-center" id="container-main">
        <!--Maakt een POST form aan, met daarin twee radiobuttons die je kan aanvinken en het antwoord wordt doorgepost..-->
               <?php echo "<h1> $gebruiker->naam $gebruiker->achternaam </h1> <br>";    ?>
       <h1><strong>Weet je zeker dat je deze Medewerker wil verwijderen?</strong></h1>
        <form method="POST">
            <label for="ja">Ja</label>
            <input type="radio" name="delete" value="ja"> <br>

            <label for="nee">Nee</label>
            <input type="radio" name="delete" value="nee"> <br>

            <input type="submit" value="bevestig">
        </form>
    </div>
</body>

<!-- Een footer die de pagina mooi afsluit. -->
<div class="container" id="footer">
    <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
        <div class="col-md-4 d-flex align-items-center">
            <span class="mb-3 mb-md-0 text-muted">© 2023 Keukenprins, Inc</span>

    </footer>
</div>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

                <br>
                <input type="submit" value="verzenden" class="btn btn-primary">
            </form>
        </div>
