<?php
require "../Classes/Gebruiker.php";
require "../Classes/Sessie.php";
$sessie = Sessie::vindSessies();

//Als de cookie niet bestaat, stuurt hij de gebruiker terug naar de login pagina.
if ($sessie == null) {
    header("location: LogInPagina.php");
    exit;
}
if (isset($_POST["naam"])) {
    $gebruiker = new Gebruiker();
    if (!empty($_FILES["bestand"]["name"])) {
        $image = $_FILES["bestand"]["name"];
        $target = "../upload/" . basename($image);
        move_uploaded_file($_FILES["bestand"]["tmp_name"], $target);
    }else {
        $image = null;
    }
    $gebruiker->naam = $_POST["naam"];
    $gebruiker->achternaam = $_POST["achternaam"];
    $gebruiker->gebruikersnaam = $_POST["gebruikernaam"];
    $gebruiker->wachtwoord = $_POST["wachtwoord"];
    $gebruiker->email = $_POST["email"];
    $gebruiker->foto = $image;
    $gebruiker->admin = isset($_POST['admin']) ? 1 : 0;
    $gebruiker->addGebruiker();
    header("location: MedewerkersOverzicht.php");
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
            <!--Maakt een POST form aan, met daarin de al bestaande data van de blog die uit de database word gehaald.-->
            <form method="POST" enctype="multipart/form-data">
                <label for="titel">Voornaam:</label>
                <input type="text" id="naam" name="naam" required><br>

                <label for="autheur">Achternaam:</label>
                <input type="text" id="achternaam" name="achternaam" required><br>

                <label for="autheur">Gebruikersnaam:</label>
                <input type="text" id="gebruikernaam" name="gebruikernaam" required><br>

                <label for="autheur">Wachtwoord:</label>
                <input type="text" id="wachtwoord" name="wachtwoord" required><br>

                <label for="autheur">email:</label>
                <input type="text" id="email" name="email" required><br>

                <label for="autheur">Admin:</label>
                <input type="checkbox" id="admin" name="admin"><br>

                <input type="hidden" name="admin_hidden" value="0">

                <label for="foto">Foto:</label>
                <input type="file" id="bestand" name="bestand"><br>


                <br>
                <input type="submit" value="verzenden" class="btn btn-primary">
            </form>
        </div>
