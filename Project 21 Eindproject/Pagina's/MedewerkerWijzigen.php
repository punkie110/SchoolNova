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

//checkt of de titel is gezet, als dat waar is voert hij de functie update uit waardoor de blog geupdate wordt.
if (isset($_POST["naam"])) {
    if (!empty($_FILES["bestand"]["name"])) {
        $image = $_FILES["bestand"]["name"];
        $target = "../upload/" . basename($image);
        $gebruiker->foto = $image;

        move_uploaded_file($_FILES["bestand"]["tmp_name"], $target);
    }
    $gebruiker->naam = $_POST["naam"];
    $gebruiker->achternaam = $_POST["achternaam"];
    $gebruiker->gebruikersnaam = $_POST["gebruikernaam"];
    $gebruiker->wachtwoord = $_POST["wachtwoord"];
    $gebruiker->email = $_POST["email"];
    $gebruiker->admin = isset($_POST['admin']) ? 1 : 0;
    $gebruiker->update();
    header("location: MedewerkersOverzicht.php");
}
?>

<head>
    <!--Een titel voor de pagina en de connecties met CSS/Bootstrap -->
    <title>Gebruiker aanpassen</title>
    <link rel="stylesheet" href="../css/jquery-te-1.4.0.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" href="../CSS/styles.css">
</head>

<body>
    <div class="background"></div>
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
        </div>

    </nav>
    <!--De hoofdcontainer-->
    <div class="container-fluid" id="container-main">
        <div class="row row-justify-content-center">
            <h1>Gebruiker Aanpassen</h1>
            <!-- Maakt een POST form aan, met daarin de al bestaande data van de gebruiker die uit de database wordt gehaald. -->
            <form method="POST" enctype="multipart/form-data">
                <div class="input-container">
                    <input type="text" id="naam" name="naam" value="<?= htmlspecialchars($gebruiker->naam); ?>" required>
                    <label for="naam">Voornaam:</label>
                </div>

                <div class="input-container">
                    <input type="text" id="achternaam" name="achternaam" value="<?= htmlspecialchars($gebruiker->achternaam); ?>" required>
                    <label for="achternaam">Achternaam:</label>
                </div>

                <div class="input-container">
                    <input type="text" id="gebruikernaam" name="gebruikernaam" value="<?= htmlspecialchars($gebruiker->gebruikersnaam); ?>" required>
                    <label for="gebruikernaam">Gebruikersnaam:</label>
                </div>

                <div class="input-container">
                    <input type="text" id="wachtwoord" class="form-control" name="wachtwoord" value="<?= htmlspecialchars($gebruiker->wachtwoord); ?>" required>
                    <label for="wachtwoord">Wachtwoord:</label>
                </div>

                <div class="input-container">
                    <input type="email" id="email" name="email" value="<?= htmlspecialchars($gebruiker->email); ?>" required>
                    <label for="email">E-mail:</label>
                </div>

                <div class="input-container">
                    <label for="admin" class="checkbox-label">
                        <input type="checkbox" id="admin" name="admin" value="1" <?= $gebruiker->admin == 1 ? 'checked' : ''; ?>>
                        Admin
                        <span class="checkmark"></span>
                    </label>
                </div>

                <input type="hidden" name="admin_hidden" value="0">

                <div class="input-container file-input">
                    <label for="bestand">Foto:</label>
                    <input type="file" id="bestand" name="bestand">
                </div>

                <button type="submit" class="btn btn-primary">Verzend</button>
            </form>
        </div>
    </div>
</body>