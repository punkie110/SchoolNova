<?php
require "Gebruiker.php";
require "Sessie.php";
require "Stap.php";

//Hier roept hij de vindSessies functie op om te kijken of er een actieve sessie is en op basis daarvan vind hij de huidige userID.
$sessie = Sessie::vindSessies();
$userId = $sessie->userId;

$gebruiker = Gebruiker::getUser($userId);
$stappen = Stap::vindStappen($userId);
$totaleStappen = Stap::stappenTotaal($stappen);
$gemiddeldeStappen = Stap::gemiddeldeStappen($stappen);

//als de sessie null is stuurt hij de gebruiker weer terug naar de inlogpagina.
if ($sessie == null) {
    header("location: Index.php");
    exit;
}
?>

<head>
    <meta charset="UTF-8">
    <title>Project Steptember</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>

<body>
    <div class="container-fluid text-center" id="containerMain">
        <div class="row row-justify-content-center" id="onderHeader">
            <div class="Steptember-afbeelding" id="afbeelding">

                <img src="Images/ProjectSteptember.png" alt="Steptember logo">

            </div>
        </div>
        <div class="row row-justify-content-center" id="backgroundImage">
            <div class="col">

                <div class="card" id="Kaartjes">

                    <div class="card-header">
                        <h3>
                            <strong>
                                Welkom <?php echo $gebruiker->voornaam ?>, dit zijn je gegevens:
                            </strong>
                        </h3>
                    </div>

                    <div class="card-body">
                        <table class="table">
                            <thead>
                                <tr>
                                    <th scope="col">Stap ID</th>
                                    <th scope="col">Datum</th>
                                    <th scope="col">totaleStappen</th>
                                </tr>
                            </thead>
                            <tbody>
                                <?php
                                //een foreach loop die nieuwe rijen maakt in de tabel met de gegevens vanuit de stap functie.
                                foreach ($stappen as $stap) {
                                ?>
                                    <tr>
                                        <td><?= $stap->id ?></td>
                                        <td><?= $stap->datum ?></td>
                                        <td><?= $stap->totaleStappen ?></td>
                                    </tr>
                                <?php
                                }

                                ?>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>

            <div class="col">

                <div class="card-header">
                    <h3>
                        <strong>
                            Overige informatie:
                        </strong>
                    </h3>
                </div>

                <div class="card-body">
                    <table class="table">
                        <thead>
                            <tr>
                                <td>Totale stappen:</td>
                                <td>Gemiddelde stappen:</td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <!-- totaleStappen en gemiddeldeStappen worden hier direct uit de functies gehaald (zie bovenin) -->
                                <td> <?= $totaleStappen ?> </td>
                                <td> <?= $gemiddeldeStappen ?> </td>
                            </tr>
                        </tbody>
                    </table>
                    <img src="Images/StappenZetten.jpg" alt="Stappen">
                </div>
            </div>
        </div>
    </div>
</body>
<div class="container" id="footer">
    <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
        <div class="col-md-4 d-flex align-items-center">
            <span class="mb-3 mb-md-0 text-muted">© 2023 Steptember, Inc</span>
        </div>
    </footer>
</div>