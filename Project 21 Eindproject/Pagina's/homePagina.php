<?php
require "../Classes/Gebruiker.php";
require "../Classes/Sessie.php";
if (isset($_COOKIE["eindproject-session"])) {

    $sessie = Sessie::getThisSession();
    $gebruiker = Gebruiker::findById($sessie->id);
} else {
    header("location: LogInPagina.php");
}
?>

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="../CSS/styles.css">

    <title>Home pagina</title>
</head>

<body>
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
        <div class="container">
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

</body>

</html>